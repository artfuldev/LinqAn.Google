using System;
using System.Collections;
using System.Collections.Generic;
using Google.Apis.Analytics.v3.Data;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Resolution
{
    internal class ProjectionReader<T> : IEnumerable<T>
    {
        private readonly GaData _data;
        private readonly Func<IRecord, T> _projector;

        public ProjectionReader(GaData data, Func<IRecord, T> projector)
        {
            _data = data;
            _projector = projector;
        }

        public IEnumerator<T> GetEnumerator() => new ProjectionEnumerator<T>(_data, _projector);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}