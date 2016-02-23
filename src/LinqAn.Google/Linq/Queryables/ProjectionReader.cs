using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using Google.Apis.Analytics.v3.Data;
using Humanizer;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;
using LinqAn.Google.Records;
using System.Reflection;

namespace LinqAn.Google.Linq.Queryables
{
    internal class ProjectionReader<T> : IEnumerable<T>
    {
        private Enumerator<T> _enumerator;

        internal ProjectionReader(GaData reader, Func<IRecord, T> projector)
        {
            _enumerator = new Enumerator<T>(reader, projector);
        }

        public IEnumerator<T> GetEnumerator()
        {
            var e = _enumerator;
            if (e == null)
            {
                throw new InvalidOperationException("Cannot enumerate more than once");
            }
            _enumerator = null;
            return e;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Enumerator<T> : ProjectionRow, IEnumerator<T>
        {
            private readonly GaData _reader;
            private readonly Func<IRecord, T> _projector;
            private Type[] _propertyTypeLookup;
            private int _current;
            private IList<string> _currentRow;
            private readonly PropertyInfo[] _propertyInfo;
            private int[] _propertyLookup;


            internal Enumerator(GaData reader, Func<IRecord, T> projector)
            {
                _reader = reader;
                _projector = projector;
                _current = 0;
                _propertyInfo = typeof (Record).GetProperties();
                _currentRow = null;
            }

            public override object GetValue(int index)
            {
                if (index < 0) throw new IndexOutOfRangeException();
                var value = _currentRow.ElementAtOrDefault(index);
                var propertyType = _propertyTypeLookup[index];
                Debug.Assert(propertyType.BaseType != null, "propertyType.BaseType != null");
                var propertyInstance = Activator.CreateInstance(propertyType);
                var valueType = typeof(IDimension).IsAssignableFrom(propertyType)
                    ? typeof(string)
                    : propertyType.BaseType.GenericTypeArguments[0];
                var newValue = valueType.Name == "TimeSpan"
                ? TimeSpan.FromSeconds(Convert.ToDouble(value))
                : Convert.ChangeType(value, valueType);
                propertyType.GetRuntimeProperty("Value")
                    .SetValue(propertyInstance, string.IsNullOrWhiteSpace(value) ? null : newValue);
                return propertyInstance;
            }

            public T Current { get; private set; }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (_reader.Rows == null || _reader.Rows.Count <= _current) return false;
                _currentRow = _reader.Rows[_current];
                if (_currentRow == null) return false;

                if (_propertyTypeLookup == null)
                    InitializePropertyTypeLookup();

                if (_propertyLookup == null)
                    InitPropertyLookup();

                var instance = new Record();
                for (var i = 0; i < _currentRow.Count; i++)
                {
                    Debug.Assert(_propertyLookup != null, "_propertyLookup != null");
                    var infoIndex = _propertyLookup[i];
                    if (infoIndex < 0) continue;
                    var propertyInfo = _propertyInfo[infoIndex];
                    var propertyType = propertyInfo.PropertyType;
                    Debug.Assert(propertyType.BaseType != null, "propertyType.BaseType != null");
                    var propertyInstance = Activator.CreateInstance(propertyType);
                    var valueType = typeof(IDimension).IsAssignableFrom(propertyType)
                        ? typeof(string)
                        : propertyType.BaseType.GenericTypeArguments[0];
                    var value = _currentRow[i];
                    var newValue = valueType.Name == "TimeSpan"
                    ? TimeSpan.FromSeconds(Convert.ToDouble(value))
                    : Convert.ChangeType(value, valueType);
                    propertyType.GetRuntimeProperty("Value")
                        .SetValue(propertyInstance, string.IsNullOrWhiteSpace(value) ? null : newValue);
                    propertyInfo.SetValue(instance, propertyInstance);
                }

                Record = instance;
                Current = _projector(Record);
                _current++;
                return true;
            }

            private void InitPropertyLookup()
            {
                var propertyNames = _reader.ColumnHeaders.Select(x => GetClassName(x.Name)).ToArray();
                _propertyLookup =
                    propertyNames.Select(name => _propertyInfo.ToList().FindIndex(x => x.Name == name)).ToArray();
            }

            private void InitializePropertyTypeLookup()
            {
                var propertyNames = _reader.ColumnHeaders.Select(x => GetClassName(x.Name)).ToArray();
                _propertyTypeLookup = propertyNames.Select(GetPropertyType).ToArray();
            }

            private static Type GetPropertyType(string id)
            {
                var typeName = GetClassName(id);
                return typeof(Record).GetProperty(typeName).PropertyType;
            }

            private static Type GetValueType(string id)
            {
                var propertyType = GetPropertyType(id);
                if (typeof (IDimension).IsAssignableFrom(propertyType))
                    return typeof (string);
                if (typeof (IMetric).IsAssignableFrom(propertyType))
                    return propertyType.BaseType?.GenericTypeArguments[0];
                return null;
            }

            private static string GetClassName(string id)
            {
                var className = id.Replace("ga:", "").Pascalize().Replace("ID", "Id");
                var match = Regex.Match(className, "^[0-9]+");
                if (!match.Success) return className;
                var number = match.ToString();
                var numberAsInt = Convert.ToInt32(number);
                var replacement = numberAsInt.ToWords().Dehumanize().Pascalize();
                var remaining = className.Replace(number, "").Pascalize();
                className = replacement + remaining;
                return className;
            }

            public void Reset()
            {
            }

            public void Dispose()
            {
            }
        }
    }
}