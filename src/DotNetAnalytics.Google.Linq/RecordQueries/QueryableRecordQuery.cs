using System;
using System.Collections.Generic;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Metrics;
using DotNetAnalytics.Google.Queries;

namespace DotNetAnalytics.Google.Linq.RecordQueries
{
    /// <summary>
    ///     Represents a query to the records in Google Analytics
    /// </summary>
    internal class QueryableRecordQuery : IRecordQuery
    {
        private List<IDimension> _dimensionsList;
        private List<IMetric> _metricsList;
        public DateTime? OptionalEndDate { get; set; }

        public List<IMetric> MetricsList
        {
            get { return _metricsList ?? (_metricsList = new List<IMetric>()); }
            set { _metricsList = value; }
        }

        public List<IDimension> DimensionsList
        {
            get { return _dimensionsList ?? (_dimensionsList = new List<IDimension>()); }
            set { _dimensionsList = value; }
        }

        public uint ViewId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate => OptionalEndDate ?? StartDate;

        public IEnumerable<IMetric> Metrics => MetricsList;

        public IEnumerable<IDimension> Dimensions => DimensionsList;
    }
}