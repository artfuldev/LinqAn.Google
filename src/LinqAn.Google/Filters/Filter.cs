using System;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;
using LinqAn.Google.Extensions;

namespace LinqAn.Google.Filters
{
    internal class Filter : IFilter
    {
        public Filter(Type type, Operator op, string value)
        {
            if (!typeof (IDimension).IsAssignableFrom(type) && !typeof (IMetric).IsAssignableFrom(type))
                throw new ArgumentException("type must be derived from IDimension or IMetric", nameof(type));
            DimensionOrMetric = ((dynamic) Activator.CreateInstance(type)).Id.ToString();
            Operator = op;
            Expression = value;
        }
        public string DimensionOrMetric { get; set; }
        public Operator Operator { get; set; }
        public string Expression { get; set; }
        public override string ToString() => DimensionOrMetric + Operator.ToStringRepresentation() + Expression;
    }
}