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
        private static readonly IFileContentGenerator MetricFileContentGenerator = new MetricFileContentGenerator();
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
                .Where(x => !x.Attributes.IsTemplated)
                .ToList();

            var metrics = selectedColumns.Where(x => x.Attributes.Type == "METRIC");
            var dimensions = selectedColumns.Where(x => x.Attributes.Type == "DIMENSION");
            
            var metricsPath = currentDirectory.Replace(@"\DotNetAnalytics.Google.Generator\bin\Debug", @"\DotNetAnalytics.Google\Metrics");
            Directory.CreateDirectory(metricsPath);
            var files = new DirectoryInfo(metricsPath).GetFiles();
            var metricFiles = files.Where(x=>x.Name!="IMetric.cs" && x.Name!="Metric.cs");
            foreach (var file in metricFiles)
                file.Delete();
            foreach (var metric in metrics)
            {
                var name = MetricFileContentGenerator.GetFileName(metric);
                var filePath = $"{metricsPath}\\{name}.cs";
                var fileContent = MetricFileContentGenerator.GenerateFileContent(metric);
                var tw = !File.Exists(filePath) ? File.CreateText(filePath) : new StreamWriter(filePath);
                tw.WriteLine(fileContent);
                tw.Close();
            }
        }
    }
}
