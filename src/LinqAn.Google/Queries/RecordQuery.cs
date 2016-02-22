using System;
using System.Collections.Generic;
using System.Linq;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Filters;
using LinqAn.Google.Metrics;
using LinqAn.Google.Sorting;

namespace LinqAn.Google.Queries
{
    public class RecordQuery : IRecordQuery
    {
        public const uint MaxRecordsPerQuery = 10000U;

        public RecordQuery(uint viewId, DateTime startDate, DateTime endDate, IEnumerable<IMetric> metrics,
            IEnumerable<IDimension> dimensions = null, IFilters filters = null, IEnumerable<ISortRule> sortRules = null)
        {
            ViewId = viewId;
            StartDate = startDate;
            EndDate = endDate;
            Metrics = metrics;
            Dimensions = dimensions ?? Enumerable.Empty<IDimension>();
            Filters = filters;
            SortRules = sortRules ?? Enumerable.Empty<ISortRule>();
        }

        public uint ViewId { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public IEnumerable<IMetric> Metrics { get; }
        public IEnumerable<IDimension> Dimensions { get; }
        public IFilters Filters { get; }
        public IEnumerable<ISortRule> SortRules { get; }
    }
}