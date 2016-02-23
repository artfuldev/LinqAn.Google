using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using Google.Apis.Analytics.v3.Data;
using Humanizer;
using LinqAn.Google.Dimensions;
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

        private class Enumerator<T> : IEnumerator<T>
        {
            private readonly RecordEnumerator _enumerator;
            private readonly Func<IRecord, T> _projector;


            internal Enumerator(GaData reader, Func<IRecord, T> projector)
            {
                _enumerator = new RecordEnumerator(reader);
                _projector = projector;
            }

            public T Current { get; private set; }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (!_enumerator.MoveNext())
                    return false;
                Current = _projector(_enumerator.Current);
                return true;
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