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

        private static void GenerateFiles(string path, IEnumerable<Column> columns, IFileContentGenerator generator,
            params string[] exlusions)
        {
            Directory.CreateDirectory(path);
            var allFiles = new DirectoryInfo(path).GetFiles();
            exlusions = exlusions ?? new string[0];
            var files = allFiles.Where(x => !exlusions.Contains(x.Name));
            foreach (var file in files)
                file.Delete();
            foreach (var column in columns)
            {
                var name = generator.GetFileName(column);
                var filePath = $"{path}\\{name}.cs";
                var fileContent = generator.GenerateFileContent(column);
                using (var tw = new StreamWriter(File.OpenWrite(filePath)))
                {
                    tw.WriteLine(fileContent);
                }
            }

        }
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
            GenerateFiles(metricsPath, metricsList, MetricFileContentGenerator, "IMetric.cs", "Metric.cs");
            var dimensionsPath = currentDirectory.Replace(@"\tools\LinqAn.Google.Generator", @"\src\LinqAn.Google\Dimensions");
            GenerateFiles(dimensionsPath, dimensionList, DimensionFileContentGenerator, "IDimension.cs", "Dimension.cs");
        }
    }
}
