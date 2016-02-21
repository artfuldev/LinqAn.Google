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
            var metrics = (from property in source.GetType().GetProperties()
                where typeof (IMetric).IsAssignableFrom(property.PropertyType)
                select (IMetric) property.GetValue(source)).ToList();
            var dimensions = (from property in source.GetType().GetProperties()
                           where typeof(IDimension).IsAssignableFrom(property.PropertyType)
                           select (IDimension)property.GetValue(source)).ToList();
            return new Record(metrics, dimensions, source.ViewId);
        }
    }
}