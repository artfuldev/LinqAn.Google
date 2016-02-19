using System;
using System.Collections.Generic;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Metrics;

namespace DotNetAnalytics.Google.Queries
{
    public interface IRecordQuery
    {
        uint ViewId { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        IEnumerable<IMetric> Metrics { get; }
        IEnumerable<IDimension> Dimensions { get; }
        uint StartIndex { get; }
        uint RecordsCount { get; }
    }
}