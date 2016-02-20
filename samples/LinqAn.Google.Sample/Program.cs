using System;
using System.IO;
using LinqAn.Google.Linq.Clients;
using LinqAn.Google.Profiles;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Linq;
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
                .Where(x => x.ViewId == viewId);

            var records = query.ToList();
            foreach (var record in records)
            {
                Console.WriteLine(JsonConvert.SerializeObject(record));
            }
            Console.ReadLine();
        }
    }
}
