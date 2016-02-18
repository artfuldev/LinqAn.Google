using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DotNetAnalytics.Google.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonPath = Directory.GetCurrentDirectory() + @"\MetaData.json";
            var json = File.ReadAllText(jsonPath);
            var metaData = JsonConvert.DeserializeObject<MetaData>(json);
            var columns = metaData.Items;
            var selectedColumns = columns
                // Remove deprecated
                .Where(x => !x.Attributes.IsDeprecated)
                // Remove calculated
                .Where(x=>string.IsNullOrWhiteSpace(x.Attributes.Calculation));
        }
    }
}
