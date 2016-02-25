using System.Text;
using LinqAn.Google.Generator.Core;

namespace LinqAn.Google.Generator.Generators
{
    public class DimensionFileContentGenerator : FileContentGenerator
    {
        protected override string GenerateFileContent(ITypeInfo typeInfo)
        {
            var fileContent = new StringBuilder();
            fileContent.AppendLine("using System.ComponentModel;\n");
            fileContent.AppendLine("namespace LinqAn.Google.Dimensions");
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
            fileContent.AppendLine($"\tpublic class {className}: Dimension");
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
    }
}