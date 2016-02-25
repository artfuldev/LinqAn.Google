using System;
using System.Text;
using System.Text.RegularExpressions;
using LinqAn.Google.Generator.Core;

namespace LinqAn.Google.Generator.Generators
{
    public class MetricFileContentGenerator : FileContentGenerator
    {
        protected override string GenerateFileContent(ITypeInfo typeInfo)
        {
            var valueTypeName = typeInfo.TypeName;
            var fileContent = new StringBuilder();
            fileContent.AppendLine("using System.ComponentModel;");
            if (IsUsingSystemRequired(valueTypeName))
            {
                fileContent.AppendLine("using System;");
            }
            fileContent.AppendLine();
            fileContent.AppendLine("namespace LinqAn.Google.Metrics");
            fileContent.AppendLine("{");
            var className = typeInfo.Id.GetClassName();
            var name = typeInfo.Name;
            var description = typeInfo.Description;
            var escapedDescription = description.Replace("\"", "\\\"");
            var isAllowedInSegments = typeInfo.AllowedInSegments.ToString().ToLowerInvariant();
            var id = typeInfo.Id;
            fileContent.AppendLine("\t/// <summary>");
            fileContent.AppendLine($"\t/// \t{description}");
            fileContent.AppendLine("\t/// </summary>");
            fileContent.AppendLine($"\t[Description(\"{escapedDescription}\")]");
            fileContent.AppendLine($"\tpublic class {className}: Metric<{valueTypeName}>");
            fileContent.AppendLine("\t{");
            fileContent.AppendLine("\t\t/// <summary>");
            fileContent.AppendLine($"\t\t/// \tInstantiates a <seealso cref=\"{className}\" />.");
            fileContent.AppendLine("\t\t/// </summary>");
            fileContent.AppendLine($"\t\tpublic {className}(): base(\"{name}\",{isAllowedInSegments},\"{id}\")");
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