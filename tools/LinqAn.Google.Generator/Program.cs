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
            var selectedColumns = columns.Where(x => !x.Attributes.IsDeprecated).ToList();

            // Filter Dimensions and Metrics
            var metrics = selectedColumns.Where(x => x.Attributes.Type == "METRIC").SelectMany(x=>x.ToTypeInfos()).ToList();
            var dimensions = selectedColumns.Where(x => x.Attributes.Type == "DIMENSION").SelectMany(x=>x.ToTypeInfos()).ToList();

            // Make sure dimensions and filters are unique
            if (dimensions.Count(dimension => metrics.Select(metric => metric.Id.GetClassName()).Contains(dimension.Id.GetClassName())) != 0)
                throw new InvalidDataException("metrics and dimensions have the same names");

            // Generate Metric files
            var metricsPath = currentDirectory.Replace(@"\tools\LinqAn.Google.Generator", @"\src\LinqAn.Google\Metrics");
            MetricsGenerator.GenerateFiles(metricsPath, metrics, true, "IMetric.cs", "Metric.cs");

            // Generate Dimension files
            var dimensionsPath = currentDirectory.Replace(@"\tools\LinqAn.Google.Generator", @"\src\LinqAn.Google\Dimensions");
            DimensionsGenerator.GenerateFiles(dimensionsPath, dimensions, true, "IDimension.cs", "Dimension.cs");

            // Generate queryable record files
            var queryableRecordsPath = currentDirectory.Replace(@"\tools\LinqAn.Google.Generator", @"\src\LinqAn.Google\Records");
            RecordsGenerator.GenerateFiles(queryableRecordsPath, metrics.Concat(dimensions));
        }
    }
}
