using System.Collections.Generic;
using System.IO;
using System.Linq;
using Humanizer;
using LinqAn.Google.Generator.Core;
using LinqAn.Google.Generator.Generators;
using Newtonsoft.Json;

namespace LinqAn.Google.Generator
{
    class Program
    {
        private static readonly IFileContentGenerator MetricsGenerator = new MetricFileContentGenerator();
        private static readonly IFileContentGenerator DimensionsGenerator = new DimensionFileContentGenerator();
        private static readonly IFileContentGenerator RecordsGenerator =new RecordFileContentGenerator();

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
                // Remove templates
                .Where(x => !x.Attributes.IsTemplated)
                .ToList();

            // Filter Dimensions and Metrics
            var metrics = selectedColumns.Where(x => x.Attributes.Type == "METRIC");
            var metricsList = metrics as IList<Column> ?? metrics.ToList();
            var dimensions = selectedColumns.Where(x => x.Attributes.Type == "DIMENSION");
            var dimensionList = dimensions as IList<Column> ?? dimensions.ToList();

            // Make sure dimensions and filters are unique
            if (dimensionList.Count(dimension => metricsList.Select(metric => metric.ToClassName()).Contains(dimension.ToClassName())) != 0)
                throw new InvalidDataException("metrics and dimensions have the same names");

            // Generate Metric files
            var metricsPath = currentDirectory.Replace(@"\tools\LinqAn.Google.Generator", @"\src\LinqAn.Google\Metrics");
            MetricsGenerator.GenerateFiles(metricsPath, metricsList, true, "IMetric.cs", "Metric.cs");

            // Generate Dimension files
            var dimensionsPath = currentDirectory.Replace(@"\tools\LinqAn.Google.Generator", @"\src\LinqAn.Google\Dimensions");
            DimensionsGenerator.GenerateFiles(dimensionsPath, dimensionList, true, "IDimension.cs", "Dimension.cs");

            // Generate queryable record files
            var queryableRecordsPath = currentDirectory.Replace(@"\tools\LinqAn.Google.Generator", @"\src\LinqAn.Google\Records");
            RecordsGenerator.GenerateFiles(queryableRecordsPath, metricsList.Concat(dimensionList));
        }
    }
}
