using System.Collections.Generic;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;

namespace LinqAn.Google.Records
{
    public interface IRecord
    {
        uint ViewId { get; }
        IEnumerable<IDimension> Dimensions { get; }
        IEnumerable<IMetric> Metrics { get; }
    }
}