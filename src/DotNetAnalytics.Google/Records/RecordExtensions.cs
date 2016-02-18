using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Metrics;
using Google.Apis.Analytics.v3.Data;

namespace DotNetAnalytics.Google.Records
{
    /// <summary>
    ///     Useful extensions for <seealso cref="IRecord"/>.
    /// </summary>
    public static class RecordExtensions
    {
        public static IRecord ToRecord(this IList<string> row, IEnumerable<IMetric> metrics,
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
                var stringDimension = (IDimension<string>) newDimension;
                if (stringDimension != null)
                    stringDimension.Value = row[iterator++];
                recordDimensions.Add(newDimension);
            }
            var recordMetrics = new List<IMetric>();
            foreach (var metric in metricsList)
            {
                var newMetric = Activator.CreateInstance(metric.GetType()) as IMetric;
                var valueType = metric.GetType().GenericTypeArguments[0];
                var value = row[iterator++];
                var valuePropertyInfo = metric.GetType().GetRuntimeProperty("Value");
                valuePropertyInfo.SetValue(newMetric, Convert.ChangeType(value, valueType));
                recordMetrics.Add(newMetric);
            }

            return new Record(recordMetrics.AsReadOnly(), recordDimensions.AsReadOnly());
        }
    }
}