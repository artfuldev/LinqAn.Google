using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Google.Apis.Analytics.v3.Data;
using LinqAn.Google.Linq.Clients;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Queryables
{
    internal class RecordReader : IEnumerable<IRecord>
    {
        RecordEnumerator _recordEnumerator;

        public RecordReader(GaData data)
        {
            _recordEnumerator = new RecordEnumerator(data);
        }

        public IEnumerator<IRecord> GetEnumerator()
        {
            var e = _recordEnumerator;
            if (e == null)
                throw new InvalidOperationException("Cannot enumerate more than once");
            _recordEnumerator = null;
            return e;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}