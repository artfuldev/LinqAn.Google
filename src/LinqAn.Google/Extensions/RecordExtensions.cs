using System.Collections.Generic;
using System.Linq;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;
using LinqAn.Google.Records;

namespace LinqAn.Google.Extensions
{
    public static class RecordExtensions
    {
        public static IQueryableRecord ToQueryableRecord(this IRecord source)
        {
            var record = new QueryableRecord() {ViewId = source.ViewId};
            foreach (var dimension in source.Dimensions)
            {
                record.GetType().GetProperty(dimension.GetType().Name).SetValue(record, dimension);
            }
            foreach (var metric in source.Metrics)
            {
                record.GetType().GetProperty(metric.GetType().Name).SetValue(record, metric);
            }
            return record;
        }

        public static IRecord ToRecord(this IQueryableRecord source)
        {
            var metrics = source.GetType()
                .GetProperties()
                .Where(property => typeof (IMetric).IsAssignableFrom(property.PropertyType))
                .Select(property => (IMetric) property.GetValue(source)).Where(x => x != null).ToList();
            var dimensions = source.GetType()
                .GetProperties()
                .Where(property => typeof (IDimension).IsAssignableFrom(property.PropertyType))
                .Select(property => (IDimension) property.GetValue(source)).Where(x => x != null).ToList();
            return new Record(metrics, dimensions, source.ViewId);
        }
    }
}