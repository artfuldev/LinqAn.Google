﻿using System;
using System.Collections.Generic;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Filters;
using LinqAn.Google.Metrics;

namespace LinqAn.Google.Queries
{
    public interface IRecordQuery
    {
        uint ViewId { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        IEnumerable<IMetric> Metrics { get; }
        IEnumerable<IDimension> Dimensions { get; }
        IFilters Filters { get; }
    }
}