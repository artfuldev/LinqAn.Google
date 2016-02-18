using System;
using System.Text;
using System.Text.RegularExpressions;
using Humanizer;

namespace DotNetAnalytics.Google.Generator
{
    public class MetricFileContentGenerator : IFileContentGenerator
    {
        public string GetFileName(Column column)
        {
            var fileName = column.Attributes.UiName.Dehumanize();
            var match = Regex.Match(fileName, "^[0-9]+");
            if (!match.Success) return fileName + "Metric";
            var number = match.ToString();
            var numberAsInt = Convert.ToInt32(number);
            var replacement = numberAsInt.ToWords().Dehumanize();
            fileName = fileName.Replace(number, replacement);
            return fileName + "Metric";
        }

        public string GenerateFileContent(Column column)
        {
            var valueTypeName = column.Attributes.DestinationTypeName;
            var fileContent = new StringBuilder();
            if (IsUsingSystemRequired(valueTypeName))
            {
                fileContent.AppendLine("using System;");
                fileContent.AppendLine();
            }
            fileContent.AppendLine("namespace DotNetAnalytics.Google.Metrics");
            fileContent.AppendLine("{");
            var className = GetFileName(column);
            var name = column.Attributes.UiName;
            var description = column.Attributes.Description;
            var isAllowedInSegments = column.Attributes.IsAllowedInSegments.ToString().ToLowerInvariant();
            var id = column.Id;
            fileContent.AppendLine($"\tpublic class {className}: Metric<{valueTypeName}>");
            fileContent.AppendLine("\t{");
            fileContent.AppendLine("\t\t/// <summary>");
            fileContent.AppendLine($"\t\t/// \t{description}");
            fileContent.AppendLine("\t\t/// </summary>");
            fileContent.AppendLine($"\t\tpublic {className}(): base(\"{name}\",\"{description}\",{isAllowedInSegments},\"{id}\")");
            fileContent.AppendLine("\t\t{");
            fileContent.AppendLine("\t\t\t");
            fileContent.AppendLine("\t\t}");
            fileContent.AppendLine("\t}");
            fileContent.AppendLine("}");
            return fileContent.ToString();
        }

        private static bool IsUsingSystemRequired(string typeName)
        {
            return typeName != "int" && typeName != "float" && typeName != "double" && typeName != "string" && typeName != "decimal";
        }
    }
}