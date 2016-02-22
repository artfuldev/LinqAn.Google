using System;
using System.Collections.Generic;
using Google.Apis.Analytics.v3.Data;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;
using LinqAn.Google.Queries;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Clients
{
    internal interface IReportingClient : IDisposable
    {
        GaData GetAllGaData(IRecordQuery query);
        GaData GetGaData(IRecordQuery query, out int? totalRecords, uint startIndex = 1,
            uint maxRecordsCount = RecordQuery.MaxRecordsPerQuery);
        IEnumerable<IQueryableRecord> GetAllRecords(IRecordQuery query);
        IEnumerable<IQueryableRecord> GetRecords(IRecordQuery query, out int? totalRecords, uint startIndex = 1,
            uint maxRecordsCount = RecordQuery.MaxRecordsPerQuery);
    }
}