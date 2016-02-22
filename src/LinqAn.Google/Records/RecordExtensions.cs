using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;

namespace LinqAn.Google.Records
{
    /// <summary>
    ///     Useful extensions for <seealso cref="IRecord" />.
    /// </summary>
    public static class RecordExtensions
    {
        public static IRecord ToRecord(this IList<string> row, IEnumerable<IMetric> metrics, uint viewId,
            IEnumerable<IDimension> dimensions = null)
        {
            dimensions = dimensions ?? Enumerable.Empty<IDimension>();
            if (row == null || row.Count == 0)
                throw new ArgumentNullException(nameof(row), "data cannot be null or empty");

            if (metrics == null)
                throw new ArgumentNullException(nameof(metrics), "metrics cannot be null");

            var metricsList = metrics as IList<IMetric> ?? metrics.ToList();
            if (!metricsList.Any())
                throw new ArgumentNullException(nameof(metrics), "metrics cannot be empty");

            var iterator = 0;
            var recordDimensions = new List<IDimension>();
            foreach (var dimension in dimensions)
            {
                var newDimension = Activator.CreateInstance(dimension.GetType()) as IDimension;
                var stringDimension = newDimension;
                if (stringDimension != null)
                    stringDimension.Value = row[iterator++];
                recordDimensions.Add(newDimension);
            }
            var recordMetrics = new List<IMetric>();
            foreach (var metric in metricsList)
            {
                var newMetric = Activator.CreateInstance(metric.GetType()) as IMetric;
                var valueType = metric.GetType().BaseType.GenericTypeArguments[0];
                var value = row[iterator++];
                var valuePropertyInfo = metric.GetType().GetRuntimeProperty("Value");
                var newValue = valueType.Name == "TimeSpan"
                    ? TimeSpan.FromSeconds(Convert.ToDouble(value))
                    : Convert.ChangeType(value, valueType);
                valuePropertyInfo.SetValue(newMetric, newValue);
                recordMetrics.Add(newMetric);
            }

            return new Record(recordMetrics.AsReadOnly(), recordDimensions.AsReadOnly());
        }
    }
}