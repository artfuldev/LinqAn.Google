using System.Text;
using Humanizer;

namespace DotNetAnalytics.Google.Generator
{
    public class MetricFileContentGenerator : IFileContentGenerator
    {
        public string GenerateFileContent(Column column)
        {
            var fileContent = new StringBuilder();
            fileContent.AppendLine("using System;");
            fileContent.AppendLine();
            fileContent.AppendLine("namespace DotNetAnalytics.Google.Metrics");
            fileContent.AppendLine("{");
            var className = column.Attributes.UiName.Dehumanize();
            var valueTypeName = column.Attributes.DestinationType.Name;
            var name = column.Attributes.UiName;
            var description = column.Attributes.Description;
            var isAllowedInSegments = column.Attributes.AllowedInSegments;
            var id = column.Id;
            fileContent.AppendLine($"\tpublic class {className}: Metric<{valueTypeName}>");
            fileContent.AppendLine("\t{");
            fileContent.AppendLine($"\t\tpublic {className}(): base(\"{name}\",\"{description}\",{isAllowedInSegments},\"{id}\")");
            fileContent.AppendLine("\t\t{");
            fileContent.AppendLine("\t\t\t");
            fileContent.AppendLine("\t\t}");
            fileContent.AppendLine("\t}");
            fileContent.AppendLine("}");
            return fileContent.ToString();
        }
    }
}