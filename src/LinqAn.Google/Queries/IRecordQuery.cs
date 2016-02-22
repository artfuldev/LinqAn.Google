using System;
using System.Collections.Generic;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Filters;
using LinqAn.Google.Metrics;
using LinqAn.Google.Sorting;

namespace LinqAn.Google.Queries
{
    internal interface IRecordQuery
    {
        uint ViewId { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        IEnumerable<IMetric> Metrics { get; }
        IEnumerable<IDimension> Dimensions { get; }
        IFilters Filters { get; }
        IEnumerable<ISortRule> SortRules { get; } 
    }
}