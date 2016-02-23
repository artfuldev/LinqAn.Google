using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Analytics.v3.Data;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    internal class ProjectionReader<T> : IEnumerable<T>
    {
        private Enumerator<T> _enumerator;

        internal ProjectionReader(GaData reader, Func<ProjectionRow, T> projector)
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
            private readonly Func<ProjectionRow, T> _projector;
            private int _current;
            private IList<string> _currentRow;

            internal Enumerator(GaData reader, Func<ProjectionRow, T> projector)
            {
                _reader = reader;
                _projector = projector;
                _current = 0;
                _currentRow = null;
            }

            public override object GetValue(int index)
            {
                if (index < 0) throw new IndexOutOfRangeException();
                var value = _currentRow.ElementAtOrDefault(index);
                return string.IsNullOrWhiteSpace(value) ? null : value;
            }

            public T Current { get; private set; }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (_reader.Rows == null || _reader.Rows.Count <= _current) return false;
                _currentRow = _reader.Rows[_current];
                if (_currentRow == null) return false;

                Current = _projector(this);
                _current++;
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