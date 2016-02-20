using System.Collections.Generic;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;

namespace LinqAn.Google.Records
{
    public class Record : IRecord
    {
        public Record(IEnumerable<IMetric> metrics, IEnumerable<IDimension> dimensions, uint viewId)
        {
            Metrics = metrics;
            Dimensions = dimensions;
            ViewId = viewId;
        }

        public IEnumerable<IDimension> Dimensions { get; }
        public IEnumerable<IMetric> Metrics { get; }
        public uint ViewId { get; }
    }
}