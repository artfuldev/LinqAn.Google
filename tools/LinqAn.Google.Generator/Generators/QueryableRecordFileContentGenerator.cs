using System.Collections.Generic;
using System.IO;
using System.Text;
using LinqAn.Google.Generator.Core;

namespace LinqAn.Google.Generator.Generators
{
    public class QueryableRecordFileContentGenerator : FileContentGenerator
    {
        public override void GenerateFiles(string rootPath, IEnumerable<Column> columns)
        {
            Directory.CreateDirectory(rootPath);
            var iQueryableContent = new StringBuilder();
            var queryableContent = new StringBuilder();
            iQueryableContent.AppendLine("using LinqAn.Google.Metrics;\nusing LinqAn.Google.Dimensions;\n");
            queryableContent.AppendLine("using LinqAn.Google.Metrics;\nusing LinqAn.Google.Dimensions;\n");
            iQueryableContent.AppendLine("namespace LinqAn.Google.Records");
            queryableContent.AppendLine("namespace LinqAn.Google.Records");
            iQueryableContent.AppendLine("{");
            queryableContent.AppendLine("{");
            iQueryableContent.AppendLine("\tpublic interface IQueryableRecord");
            queryableContent.AppendLine("\tpublic class QueryableRecord : IQueryableRecord");
            iQueryableContent.AppendLine("\t{");
            queryableContent.AppendLine("\t{");
            iQueryableContent.AppendLine("\t\tuint ViewId { get; }");
            queryableContent.AppendLine("\t\tpublic uint ViewId { get; set; }");
            iQueryableContent.AppendLine("\t\tSystem.DateTime RecordDate { get; }");
            queryableContent.AppendLine("\t\tpublic System.DateTime RecordDate { get; set; }");
            foreach (var column in columns)
            {
                var name = column.ToClassName();
                iQueryableContent.AppendLine($"\t\t{name} {name} {{ get; }}");
                queryableContent.AppendLine($"\t\tpublic {name} {name} {{ get; set; }}");
            }
            iQueryableContent.AppendLine("\t}");
            queryableContent.AppendLine("\t}");
            iQueryableContent.AppendLine("}");
            queryableContent.AppendLine("}");
            var filePath = $"{rootPath}\\IQueryableRecord.cs";
            var fileContent = iQueryableContent;
            using (var tw = new StreamWriter(File.OpenWrite(filePath)))
            {
                tw.WriteLine(fileContent);
            }
            filePath = $"{rootPath}\\QueryableRecord.cs";
            fileContent = queryableContent;
            using (var tw = new StreamWriter(File.OpenWrite(filePath)))
            {
                tw.WriteLine(fileContent);
            }
        }
    }
}