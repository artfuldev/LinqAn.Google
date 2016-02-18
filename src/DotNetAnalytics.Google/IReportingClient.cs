using System;
using System.Collections.Generic;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Metrics;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google
{
    public interface IReportingClient
    {
        IEnumerable<IRecord> GetAllRecords(DateTime date, IEnumerable<IMetric> metrics,
            IEnumerable<IDimension> dimensions);

        IEnumerable<IRecord> GetRecords(DateTime date, IEnumerable<IMetric> metrics, out int? totalRecords,
            IEnumerable<IDimension> dimensions = null, int startIndex = 1, int maxRecordsCount = 10000);

        IEnumerable<IRecord> GetAllRecords(DateTime startDate, DateTime endDate, IEnumerable<IMetric> metrics,
            IEnumerable<IDimension> dimensions);

        IEnumerable<IRecord> GetRecords(DateTime startDate, DateTime endDate, IEnumerable<IMetric> metrics,
            out int? totalRecords, IEnumerable<IDimension> dimensions = null, int startIndex = 1,
            int maxRecordsCount = 10000);
    }
}