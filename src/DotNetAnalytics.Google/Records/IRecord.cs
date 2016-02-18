using System.Collections.Generic;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Metrics;

namespace DotNetAnalytics.Google.Records
{
    public interface IRecord
    {
        IEnumerable<IDimension> Dimensions { get; }
        IEnumerable<IMetric> Metrics { get; }
    }
}