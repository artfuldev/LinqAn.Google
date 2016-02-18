using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using Newtonsoft.Json;

namespace DotNetAnalytics.Google.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Directory.GetCurrentDirectory() + @"\";
            var jsonPath = currentDirectory + "MetaData.json";
            var json = File.ReadAllText(jsonPath);
            var metaData = JsonConvert.DeserializeObject<MetaData>(json);
            var columns = metaData.Items;
            var selectedColumns = columns
                // Remove deprecated
                .Where(x => !x.Attributes.IsDeprecated)
                // Remove calculated
                .Where(x => string.IsNullOrWhiteSpace(x.Attributes.Calculation))
                // Remove templates
                .Where(x => !x.Attributes.UiName.Contains("X"))
                .ToList();

            var metrics = selectedColumns.Where(x => x.Attributes.Type == "METRIC");
            var dimensions = selectedColumns.Where(x => x.Attributes.Type == "DIMENSION");

            var metricsPath = currentDirectory + "Metrics";
            Directory.CreateDirectory(metricsPath);
            foreach (var metric in metrics)
            {
                var name = metric.Attributes.UiName.Pascalize();
                var filePath = $"{metricsPath}\\{name}.cs";
                var fileContent = "This is the metric file for " + name;
                var tw = !File.Exists(filePath) ? File.CreateText(filePath) : new StreamWriter(filePath);
                tw.WriteLine(fileContent);
                tw.Close();
            }
        }
    }
}
