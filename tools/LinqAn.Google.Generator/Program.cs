using System.Collections.Generic;
using System.IO;
using System.Linq;
using Humanizer;
using Newtonsoft.Json;

namespace LinqAn.Google.Generator
{
    class Program
    {
        private static readonly IFileContentGenerator MetricFileContentGenerator = new MetricFileContentGenerator();
        private static readonly IFileContentGenerator DimensionFileContentGenerator = new DimensionFileContentGenerator();
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

            // Filter Dimensions and Metrics
            var metrics = selectedColumns.Where(x => x.Attributes.Type == "METRIC");
            var metricsList = metrics as IList<Column> ?? metrics.ToList();
            var dimensions = selectedColumns.Where(x => x.Attributes.Type == "DIMENSION");
            var dimensionList = dimensions as IList<Column> ?? dimensions.ToList();

            // Clean up dimensions list
            foreach (var dimension in dimensionList.Where(dimension => metricsList.Select(x => x.Attributes.UiName).Contains(dimension.Attributes.UiName)))
                dimension.Attributes.UiName = dimension.Id.Replace("ga:", "").Pascalize().Humanize().Titleize();

            var metricsPath = currentDirectory.Replace(@"\tools\LinqAn.Google.Generator", @"\src\LinqAn.Google\Metrics");
            Directory.CreateDirectory(metricsPath);
            var files = new DirectoryInfo(metricsPath).GetFiles();
            var metricFiles = files.Where(x => x.Name != "IMetric.cs" && x.Name != "Metric.cs");
            foreach (var file in metricFiles)
                file.Delete();
            foreach (var metric in metricsList)
            {
                var name = MetricFileContentGenerator.GetFileName(metric);
                var filePath = $"{metricsPath}\\{name}.cs";
                var fileContent = MetricFileContentGenerator.GenerateFileContent(metric);
                using (var tw = new StreamWriter(File.OpenWrite(filePath)))
                {
                    tw.WriteLine(fileContent);
                }
            }
            var dimensionsPath = currentDirectory.Replace(@"\tools\LinqAn.Google.Generator", @"\src\LinqAn.Google\Dimensions");
            Directory.CreateDirectory(dimensionsPath);
            var existingDimensionFiles = new DirectoryInfo(dimensionsPath).GetFiles();
            var dimensionFiles = existingDimensionFiles.Where(x => x.Name != "IDimension.cs" && x.Name != "Dimension.cs");
            foreach (var file in dimensionFiles)
                file.Delete();
            foreach (var dimension in dimensionList)
            {
                var name = DimensionFileContentGenerator.GetFileName(dimension);
                var filePath = $"{dimensionsPath}\\{name}.cs";
                var fileContent = DimensionFileContentGenerator.GenerateFileContent(dimension);
                using (var tw = new StreamWriter(File.OpenWrite(filePath)))
                {
                    tw.WriteLine(fileContent);
                }
            }
        }
    }
}
