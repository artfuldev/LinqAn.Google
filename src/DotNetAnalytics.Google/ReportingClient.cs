using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Metrics;
using DotNetAnalytics.Google.Profiles;
using DotNetAnalytics.Google.Records;
using Google.Apis.Analytics.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;

namespace DotNetAnalytics.Google
{
    public class ReportingClient : IReportingClient
    {
        private readonly string _viewId;
        private readonly AnalyticsService _service;
        public ReportingClient(IAnalyticsProfile profile)
        {
            _viewId = "ga:" + profile.ViewId;
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
                new AnalyticsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = applicationName,
                });
        }

        public IEnumerable<IRecord> GetAllRecords(DateTime date, IEnumerable<IMetric> metrics, IEnumerable<IDimension> dimensions)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRecord> GetRecords(DateTime date, IEnumerable<IMetric> metrics, IEnumerable<IDimension> dimensions, int startIndex = 1,
            int maxRecordsCount = 10000)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRecord> GetAllRecords(DateTime startDate, DateTime endDate, IEnumerable<IMetric> metrics, IEnumerable<IDimension> dimensions)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRecord> GetRecords(DateTime startDate, DateTime endDate, IEnumerable<IMetric> metrics, IEnumerable<IDimension> dimensions,
            int startIndex = 1, int maxRecordsCount = 10000)
        {
            throw new NotImplementedException();
        }
    }
}