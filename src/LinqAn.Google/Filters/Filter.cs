using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;

namespace LinqAn.Google.Filters
{
    internal class Filter : IFilter
    {
        private object _dimensionOrMetric;

        public object DimensionOrMetric
        {
            get { return _dimensionOrMetric; }
            set
            {
                if (value is IDimension || value is IMetric)
                    _dimensionOrMetric = value;
            }
        }

        public Operator Operator { get; set; }
        public object Expression { get; set; }
    }
}