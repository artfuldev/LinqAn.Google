using System;
using System.Collections;
using System.Collections.Generic;
using Google.Apis.Analytics.v3.Data;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Resolution
{
    internal class ProjectionEnumerator<T> : IEnumerator<T>
    {
        private readonly RecordEnumerator _enumerator;
        private readonly Func<IRecord, T> _projector;


        internal ProjectionEnumerator(GaData reader, Func<IRecord, T> projector)
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
            _enumerator.Dispose();
        }
    }
}