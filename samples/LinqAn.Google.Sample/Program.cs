using System;
using System.IO;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Linq.Clients;
using LinqAn.Google.Linq.Repositories;
using LinqAn.Google.Metrics;
using LinqAn.Google.Profiles;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Linq;

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
                .Include(x => new Source())
                .Include(x => new Medium())
                // Include Metrics
                .Include(x => new Hits())
                .Include(x => new Sessions())
                .Include(x => new Metrics.SessionDuration());

            var records = query.Select().ToList();
            foreach (var record in records)
            {
                Console.WriteLine(JsonConvert.SerializeObject(record));
            }
            Console.ReadLine();
        }
    }
}
