using System.Collections.Generic;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Metrics;

namespace DotNetAnalytics.Google.Records
{
    public class Record : IRecord
    {
        public Record(IEnumerable<IMetric> metrics, IEnumerable<IDimension> dimensions)
        {
            Metrics = metrics;
            Dimensions = dimensions;
        }

        public IEnumerable<IDimension> Dimensions { get; }
        public IEnumerable<IMetric> Metrics { get; }
    }
}