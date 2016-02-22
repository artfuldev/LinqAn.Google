using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;
using LinqAn.Google.Extensions;

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
        public override string ToString()
        {
            var dimension = DimensionOrMetric as IDimension;
            if (dimension != null) return dimension.Id + Operator.ToStringRepresentation() + Expression;
            var metric = DimensionOrMetric as IMetric;
            return metric == null ? "" : metric.Id + Operator.ToStringRepresentation() + Expression;
        }
    }
}