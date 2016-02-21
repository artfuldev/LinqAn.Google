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
        IEnumerable<IRecord> GetAllRecords(IRecordQuery query);

        IEnumerable<IRecord> GetRecords(IRecordQuery query, out int? totalRecords, uint startIndex = 1,
            uint maxRecordsCount = RecordQuery.MaxRecordsPerQuery);

        IEnumerable<IRecord> GetAllRecords(uint viewId, DateTime date, IEnumerable<IMetric> metrics,
            IEnumerable<IDimension> dimensions);

        IEnumerable<IRecord> GetRecords(uint viewId, DateTime date, IEnumerable<IMetric> metrics, out int? totalRecords,
            IEnumerable<IDimension> dimensions = null, uint startIndex = 1,
            uint maxRecordsCount = RecordQuery.MaxRecordsPerQuery);

        IEnumerable<IRecord> GetAllRecords(uint viewId, DateTime startDate, DateTime endDate,
            IEnumerable<IMetric> metrics,
            IEnumerable<IDimension> dimensions);

        IEnumerable<IRecord> GetRecords(uint viewId, DateTime startDate, DateTime endDate, IEnumerable<IMetric> metrics,
            out int? totalRecords, IEnumerable<IDimension> dimensions = null, uint startIndex = 1,
            uint maxRecordsCount = RecordQuery.MaxRecordsPerQuery);

        IEnumerable<IQueryableRecord> GetAllQueryableRecords(IRecordQuery query);

        IEnumerable<IQueryableRecord> GetQueryableRecords(IRecordQuery query, out int? totalRecords, uint startIndex = 1,
            uint maxRecordsCount = RecordQuery.MaxRecordsPerQuery);
    }
}