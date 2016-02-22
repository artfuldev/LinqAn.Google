using System.Collections.Generic;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;

namespace LinqAn.Google.Records
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