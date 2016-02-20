using System;
using System.Text;
using System.Text.RegularExpressions;
using Humanizer;

namespace LinqAn.Google.Generator.Generators
{
    public class MetricFileContentGenerator : FileContentGenerator
    {
        protected override string GetFileName(Column column)
        {
            var fileName = column.Attributes.UiName.Dehumanize();
            var match = Regex.Match(fileName, "^[0-9]+");
            if (!match.Success) return fileName;
            var number = match.ToString();
            var numberAsInt = Convert.ToInt32(number);
            var replacement = numberAsInt.ToWords().Dehumanize();
            fileName = fileName.Replace(number, replacement);
            return fileName;
        }

        protected override string GenerateFileContent(Column column)
        {
            var valueTypeName = column.Attributes.DestinationTypeName;
            var fileContent = new StringBuilder();
            if (IsUsingSystemRequired(valueTypeName))
            {
                fileContent.AppendLine("using System;");
                fileContent.AppendLine();
            }
            fileContent.AppendLine("namespace LinqAn.Google.Metrics");
            fileContent.AppendLine("{");
            var className = GetFileName(column);
            var name = column.Attributes.UiName;
            var description = column.Attributes.Description;
            var escapedDescription = description.Replace("\"", "\\\"");
            var isAllowedInSegments = column.Attributes.IsAllowedInSegments.ToString().ToLowerInvariant();
            var id = column.Id;
            fileContent.AppendLine("\t/// <summary>");
            fileContent.AppendLine($"\t/// \t{description}");
            fileContent.AppendLine("\t/// </summary>");
            fileContent.AppendLine($"\tpublic class {className}: Metric<{valueTypeName}>");
            fileContent.AppendLine("\t{");
            fileContent.AppendLine("\t\t/// <summary>");
            fileContent.AppendLine($"\t/// \tInstantiates a <seealso cref=\"{className}\" />.");
            fileContent.AppendLine("\t\t/// </summary>");
            fileContent.AppendLine($"\t\tpublic {className}(): base(\"{name}\",\"{escapedDescription}\",{isAllowedInSegments},\"{id}\")");
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