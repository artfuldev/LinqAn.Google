using System;
using System.IO;
using LinqAn.Google.Linq.Clients;
using LinqAn.Google.Profiles;
using Microsoft.Extensions.Configuration;
using System.Linq;
using LinqAn.Google.Extensions;
using LinqAn.Google.Linq.Queryables;

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
            var recordsDataSet = new RecordsDataSet(reportingClient);
            var query = recordsDataSet
                // View Id
                .Where(x => x.ViewId == viewId)
                // Start Date, End Date
                .Where(x => x.RecordDate == DateTime.Today)
                // Include Dimensions
                .Include(x => x.Source)
                .Include(x => x.Medium)
                // Include Metrics
                .Include(x => x.Hits)
                .Include(x => x.Sessions)
                .Include(x => x.SessionDuration)
                // Take only 20 records
                .Take(20);

            var records = query.ToList().Select(x => x.ToRecord());
            foreach (var record in records)
            {
                Console.WriteLine(record.ToStringRepresentation());
            }
            Console.ReadLine();
        }
    }
}
