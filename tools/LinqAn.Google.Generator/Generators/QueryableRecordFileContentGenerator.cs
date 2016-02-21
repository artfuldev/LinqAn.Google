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
            iQueryableContent.AppendLine("using LinqAn.Google.Metrics;\nusing LinqAn.Google.Dimensions;\n");
            iQueryableContent.AppendLine("namespace LinqAn.Google.Records");
            iQueryableContent.AppendLine("{");
            iQueryableContent.AppendLine("\tpublic interface IQueryableRecord");
            iQueryableContent.AppendLine("\t{\n\t\t/// <summary>\n\t\t /// \tThe id of the view to query.\n\t\t/// </summary>");
            iQueryableContent.AppendLine("\t\tuint ViewId { get; }");
            iQueryableContent.AppendLine("\t{\n\t\t/// <summary>\n\t\t /// \tThe date of the record to query.\n\t\t/// </summary>");
            iQueryableContent.AppendLine("\t\tSystem.DateTime RecordDate { get; }");

            var queryableContent = new StringBuilder();
            queryableContent.AppendLine("using LinqAn.Google.Metrics;\nusing LinqAn.Google.Dimensions;\n");
            queryableContent.AppendLine("namespace LinqAn.Google.Records");
            queryableContent.AppendLine("{");
            queryableContent.AppendLine("\tpublic class QueryableRecord : IQueryableRecord");
            queryableContent.AppendLine("\t{\n\t\t/// <summary>\n\t\t /// \tThe id of the view to query.\n\t\t/// </summary>");
            queryableContent.AppendLine("\t\tpublic uint ViewId { get; set; }");
            queryableContent.AppendLine("\t{\n\t\t/// <summary>\n\t\t /// \tThe date of the record to query.\n\t\t/// </summary>");
            queryableContent.AppendLine("\t\tpublic System.DateTime RecordDate { get; set; }");

            foreach (var column in columns)
            {
                var name = column.ToClassName();
                var description = column.Attributes.Description;

                iQueryableContent.AppendLine($"\t\t/// <summary>\n\t\t/// \t{description}\n\t\t/// </summary>");
                iQueryableContent.AppendLine($"\t\t{name} {name} {{ get; }}");

                queryableContent.AppendLine($"\t\t/// <summary>\n\t\t/// \t{description}\n\t\t/// </summary>");
                queryableContent.AppendLine($"\t\tpublic {name} {name} {{ get; set; }}");
            }

            iQueryableContent.AppendLine("\t}\n}");
            queryableContent.AppendLine("\t}\n}");

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