using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace LinqAn.Google.Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("gasettings.json");
            var config = builder.Build();
            var viewId = Convert.ToUInt32(config["profile:view_id"]);
            var serviceEmail = config["profile:service_account_email"];
            var applicationName = config["profile:application_name"];
            var keyFilePath = Directory.GetCurrentDirectory() + "\\" + config["profile:key_file_name"];
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
