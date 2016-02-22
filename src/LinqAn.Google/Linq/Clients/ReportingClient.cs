using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Google.Apis.Analytics.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Extensions;
using LinqAn.Google.Filters;
using LinqAn.Google.Metrics;
using LinqAn.Google.Profiles;
using LinqAn.Google.Queries;
using LinqAn.Google.Records;

namespace LinqAn.Google.Linq.Clients
{
    internal class ReportingClient : IReportingClient
    {
        private readonly DateTime _minimumDate = new DateTime(2000, 1, 1);
        private readonly AnalyticsService _service;

        public ReportingClient(IAnalyticsProfile profile)
        {
            var serviceAccountEmail = profile.ServiceAccountEmail;
            var keyFile = profile.KeyFilePath;
            var applicationName = profile.ApplicationName;
            var certificate = new X509Certificate2(keyFile, "notasecret",
                X509KeyStorageFlags.Exportable | X509KeyStorageFlags.MachineKeySet);
            var credential =
                new ServiceAccountCredential(
                    new ServiceAccountCredential.Initializer(serviceAccountEmail)
                    {
                        Scopes = new[] {AnalyticsService.Scope.Analytics}
                    }.FromCertificate(certificate));
            _service =
                new AnalyticsService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = applicationName
                });
        }

        private IEnumerable<IRecord> GetAllRecords(uint viewId, DateTime startDate, DateTime endDate,
            IEnumerable<IMetric> metrics, IEnumerable<IDimension> dimensions, IFilters filters)
        {
            var records = new List<IRecord>();
            int? totalRecords;
            var metricsList = metrics as IList<IMetric> ?? metrics.ToList();
            var dimensionsList = dimensions as IList<IDimension> ?? dimensions.ToList();
            records.AddRange(GetRecords(viewId, startDate, endDate, metricsList, out totalRecords, dimensionsList,
                filters));
            if (totalRecords == null || totalRecords < 10000)
                return records;
            while (totalRecords > records.Count)
            {
                records.AddRange(GetRecords(viewId, startDate, endDate, metricsList, out totalRecords, dimensionsList,
                    filters, Convert.ToUInt32(records.Count + 1)));
            }
            return records;
        }

        private IEnumerable<IRecord> GetRecords(uint viewId, DateTime startDate, DateTime endDate,
            IEnumerable<IMetric> metrics, out int? totalRecords, IEnumerable<IDimension> dimensions = null, IFilters filters = null,
            uint startIndex = 1, uint maxRecordsCount = RecordQuery.MaxRecordsPerQuery)
        {
            dimensions = dimensions ?? Enumerable.Empty<IDimension>();
            if (startDate < _minimumDate)
                throw new ArgumentOutOfRangeException(nameof(startDate),
                    "start date cannot be less than " + _minimumDate.ToShortDateString());
            var start = startDate.ToString("yyyy-MM-dd");
            var end = endDate.ToString("yyyy-MM-dd");
            var metricsList = metrics as IList<IMetric> ?? metrics.ToList();
            var metricsString = metricsList.ToStringRepresentation();
            var query = _service.Data.Ga.Get("ga:" + viewId, start, end, metricsString);
            var dimensionsList = dimensions as IList<IDimension> ?? dimensions.ToList();
            query.Dimensions = dimensionsList.ToStringRepresentation();
            query.StartIndex = Convert.ToInt32(startIndex);
            query.MaxResults = Convert.ToInt32(maxRecordsCount);
            var filterString = filters?.ToString();
            if (!string.IsNullOrWhiteSpace(filterString))
                query.Filters = filterString;
            query.SamplingLevel = DataResource.GaResource.GetRequest.SamplingLevelEnum.HIGHERPRECISION;
            var queryResult = query.Execute();
            totalRecords = queryResult.TotalResults;
            return queryResult.Rows.Select(row => row.ToRecord(metricsList, viewId, dimensionsList));
        }

        public IEnumerable<IQueryableRecord> GetAllRecords(IRecordQuery query)
        {
            return
                GetAllRecords(query.ViewId, query.StartDate, query.EndDate, query.Metrics, query.Dimensions, query.Filters)
                    .Select(x => x.ToQueryableRecord());
        }

        public IEnumerable<IQueryableRecord> GetRecords(IRecordQuery query, out int? totalRecords, uint startIndex = 1,
            uint maxRecordsCount = RecordQuery.MaxRecordsPerQuery)
        {
            return GetRecords(query.ViewId, query.StartDate, query.EndDate, query.Metrics, out totalRecords,
                query.Dimensions, query.Filters, startIndex, maxRecordsCount).Select(x => x.ToQueryableRecord());
        }
    }
}