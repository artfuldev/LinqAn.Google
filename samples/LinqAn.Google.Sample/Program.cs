using LinqAn.Google.Extensions;
using LinqAn.Google.Linq.Queryables;
using LinqAn.Google.Profiles;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
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
            var googleAnalytics = new GoogleAnalyticsContext(profile);
            var query = googleAnalytics.Records
                // View Id
                .Where(x => x.ViewId == viewId)
                // Start Date, End Date
                .Where(x => x.RecordDate == DateTime.Today)
                // Include Dimensions
                .Include(x => x.Source)
                .Include(x => x.Medium)
                // Include Metrics
                .Include(x => x.Pageviews)
                .Include(x => x.Sessions)
                .Include(x => x.SessionDuration)
                // Skip 1 record
                .Skip(1)
                // Take only 5 records
                .Take(5);

            var records = query.ToList().Select(x => x.ToRecord());
            foreach (var record in records)
            {
                Console.WriteLine(record.ToStringRepresentation());
            }
            Console.ReadLine();
        }
    }
}
