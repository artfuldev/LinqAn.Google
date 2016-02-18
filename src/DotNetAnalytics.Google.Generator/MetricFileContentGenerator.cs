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
            fileContent.AppendLine("using DotNetAnalytics.Google.Core;");
            fileContent.AppendLine();
            fileContent.AppendLine("namespace DotNetAnalytics.Google.Metrics");
            fileContent.AppendLine("{");
            var className = column.Attributes.UiName.Dehumanize();
            fileContent.AppendLine("public class " + className + ": Metric");
            fileContent.AppendLine("{");
            fileContent.AppendLine("}");
            fileContent.AppendLine("}");
            return fileContent.ToString();
        }
    }
}