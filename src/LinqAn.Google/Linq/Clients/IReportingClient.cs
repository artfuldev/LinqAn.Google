using System;
using System.Collections.Generic;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;
using LinqAn.Google.Queries;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Clients
{
    public interface IReportingClient
    {
        IEnumerable<IQueryableRecord> GetAllQueryableRecords(IRecordQuery query);

        IEnumerable<IQueryableRecord> GetQueryableRecords(IRecordQuery query, out int? totalRecords, uint startIndex = 1,
            uint maxRecordsCount = RecordQuery.MaxRecordsPerQuery);
    }
}