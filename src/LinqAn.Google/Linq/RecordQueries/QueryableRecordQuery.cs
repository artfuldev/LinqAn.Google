using System;
using System.Collections.Generic;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Metrics;
using LinqAn.Google.Queries;

namespace LinqAn.Google.Linq.RecordQueries
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
        public bool QueryAll { get; set; } = true;
        public uint? StartIndex { get; set; } = 1U;
        public uint? RecordsCount { get; set; } = RecordQuery.MaxRecordsPerQuery;
    }
}