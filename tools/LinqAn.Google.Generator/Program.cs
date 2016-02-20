using System.Collections.Generic;
using System.IO;
using System.Linq;
using Humanizer;
using LinqAn.Google.Generator.Generators;
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

            // Generate Metric files
            var metricsPath = currentDirectory.Replace(@"\tools\LinqAn.Google.Generator", @"\src\LinqAn.Google\Metrics");
            MetricFileContentGenerator.GenerateFiles(metricsPath, metricsList, "IMetric.cs", "Metric.cs");

            // Generate Dimension files
            var dimensionsPath = currentDirectory.Replace(@"\tools\LinqAn.Google.Generator", @"\src\LinqAn.Google\Dimensions");
            DimensionFileContentGenerator.GenerateFiles(dimensionsPath, dimensionList, "IDimension.cs", "Dimension.cs");
        }
    }
}
