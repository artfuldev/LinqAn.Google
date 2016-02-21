using System.Reflection;
using System.Text;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;
using LinqAn.Google.Records;

namespace LinqAn.Google.Sample
{
    public static class RecordExtensions
    {
        public static string ToStringRepresentation(this IDimension dimension)
        {
            return $"{dimension.Name} : {dimension.GetType().GetRuntimeProperty("Value").GetValue(dimension)}";
        }

        public static string ToStringRepresentation(this IMetric metric)
        {
            return $"{metric.Name} : {metric.GetType().GetRuntimeProperty("Value").GetValue(metric)}";
        }

        public static string ToStringRepresentation(this IRecord record)
        {
            var representaion = new StringBuilder();
            foreach (var dimension in record.Dimensions)
                representaion.AppendLine(dimension.ToStringRepresentation());
            foreach (var metric in record.Metrics)
                representaion.AppendLine(metric.ToStringRepresentation());
            return representaion.ToString();
        }
    }
}