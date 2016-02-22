using System.Linq;
using LinqAn.Google.Records;

namespace LinqAn.Google.Sample
{
    public static class RecordExtensions
    {
        public static string ToStringRepresentation(this IRecord record)
        {
            var representaion = record.Dimensions.Aggregate("", (current, dimension) => current + dimension + "\n");
            return record.Metrics.Aggregate(representaion, (current, metric) => current + metric + "\n");
        }
    }
}