using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Metrics;
using DotNetAnalytics.Google.Profiles;
using Newtonsoft.Json;

namespace DotNetAnalytics.Google.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var appSettingsReader = new AppSettingsReader();
            var viewId = (uint)appSettingsReader.GetValue("ViewId", typeof(uint));
            var serviceEmail = (string)appSettingsReader.GetValue("ServiceEmail", typeof(string));
            var applicationName = (string)appSettingsReader.GetValue("ApplicationName", typeof (string));
            var keyFilePath = Directory.GetCurrentDirectory() + @"\key.p12";
            var profile = new AnalyticsProfile(serviceEmail, keyFilePath, applicationName);
            var reportingClient = new ReportingClient(profile) {ViewId = viewId};
            var metrics = new IMetric[]
            {
                new HitsMetric(),
                new SessionsMetric(),
                new SessionDurationMetric()
            };
            var dimensions = new IDimension[]
            {
                new SourceDimension(),
                new MediumDimension(),
            };
            var records = reportingClient.GetAllRecords(DateTime.Today, metrics, dimensions);
            foreach (var record in records)
            {
                Console.WriteLine(JsonConvert.SerializeObject(record));
            }
            Console.ReadLine();
        }
    }
}
