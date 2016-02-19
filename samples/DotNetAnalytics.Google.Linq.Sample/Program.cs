using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Linq.Repositories;
using DotNetAnalytics.Google.Metrics;
using DotNetAnalytics.Google.Profiles;
using Newtonsoft.Json;

namespace DotNetAnalytics.Google.Linq.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var appSettingsReader = new AppSettingsReader();
            var viewId = (uint)appSettingsReader.GetValue("ViewId", typeof(uint));
            var serviceEmail = (string)appSettingsReader.GetValue("ServiceEmail", typeof(string));
            var applicationName = (string)appSettingsReader.GetValue("ApplicationName", typeof(string));
            var keyFilePath = Directory.GetCurrentDirectory() + @"\key.p12";
            var profile = new AnalyticsProfile(serviceEmail, keyFilePath, applicationName);
            var reportingClient = new ReportingClient(profile);
            var repository = new Repository(reportingClient);
            var query = repository
                // View Id
                .Query(x => x.ViewId == viewId)
                // Include Dimensions
                .Include(x => new SourceDimension())
                .Include(x => new MediumDimension())
                // Include Metrics
                .Include(x => new HitsMetric())
                .Include(x => new SessionsMetric())
                .Include(x => new SessionDurationMetric());

            var records = query.Select().ToList();
            foreach (var record in records)
            {
                Console.WriteLine(JsonConvert.SerializeObject(record));
            }
            Console.ReadLine();
        }
    }
}
