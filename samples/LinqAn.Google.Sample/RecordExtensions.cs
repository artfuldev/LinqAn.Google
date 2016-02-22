using System.Linq;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;
using LinqAn.Google.Records;

namespace LinqAn.Google.Sample
{
    public static class RecordExtensions
    {
        public static string ToStringRepresentation(this IRecord record)
        {
            return record.GetType().GetProperties().Where(propertyInfo =>
            {
                var propertyType = propertyInfo.PropertyType;
                return typeof (IDimension).IsAssignableFrom(propertyType) ||
                       typeof (IMetric).IsAssignableFrom(propertyType);
            })
                .Select(propertyInfo => propertyInfo.GetValue(record))
                .Where(value => value != null)
                .Aggregate("", (current, value) => current + (value + "\n"));
        }
    }
}