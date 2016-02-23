using System.Collections;
using System.Collections.Generic;
using Google.Apis.Analytics.v3.Data;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Resolution
{
    internal class RecordReader : IEnumerable<IRecord>
    {
        private readonly GaData _data;

        public RecordReader(GaData data)
        {
            _data = data;
        }

        public IEnumerator<IRecord> GetEnumerator() => new RecordEnumerator(_data);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}