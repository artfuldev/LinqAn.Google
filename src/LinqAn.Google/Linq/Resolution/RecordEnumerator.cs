using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Google.Apis.Analytics.v3.Data;
using Humanizer;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Resolution
{
    internal class RecordEnumerator : IEnumerator<IRecord>
    {
        private readonly GaData _reader;
        private readonly PropertyInfo[] _propertyInfo;
        private int[] _propertyLookup;
        private int _current;

        internal RecordEnumerator(GaData reader)
        {
            _reader = reader;
            _propertyInfo = typeof(Record).GetProperties();
            _current = 0;
        }

        public IRecord Current { get; private set; }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (_reader.Rows == null || _reader.Rows.Count <= _current) return false;
            var row = _reader.Rows[_current];
            if (row == null) return false;

            if (_propertyLookup == null)
                InitPropertyLookup();

            var instance = new Record();
            for (var i = 0; i < row.Count; i++)
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
                var value = row[i];
                var newValue = valueType.Name == "TimeSpan"
                    ? TimeSpan.FromSeconds(Convert.ToDouble(value))
                    : Convert.ChangeType(value, valueType);
                propertyType.GetRuntimeProperty("Value")
                    .SetValue(propertyInstance, string.IsNullOrWhiteSpace(value) ? null : newValue);
                propertyInfo.SetValue(instance, propertyInstance);
            }
            Current = instance;
            _current++;
            return true;
        }

        private void InitPropertyLookup()
        {
            var propertyNames = _reader.ColumnHeaders.Select(x => GetClassName(x.Name)).ToArray();
            _propertyLookup =
                propertyNames.Select(name => _propertyInfo.ToList().FindIndex(x => x.Name == name)).ToArray();
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