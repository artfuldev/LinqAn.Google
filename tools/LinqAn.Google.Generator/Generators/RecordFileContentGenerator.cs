using System.Collections.Generic;
using System.IO;
using System.Text;
using LinqAn.Google.Generator.Core;

namespace LinqAn.Google.Generator.Generators
{
    public class RecordFileContentGenerator : FileContentGenerator
    {
        public override void GenerateFiles(string rootPath, IEnumerable<Column> columns)
        {
            Directory.CreateDirectory(rootPath);

            var interfaceContent = new StringBuilder();
            interfaceContent.AppendLine("using LinqAn.Google.Metrics;\nusing LinqAn.Google.Dimensions;\n");
            interfaceContent.AppendLine("namespace LinqAn.Google.Records");
            interfaceContent.AppendLine("{");
            interfaceContent.AppendLine("\tpublic interface IRecord");
            interfaceContent.AppendLine("\t{\n\t\t/// <summary>\n\t\t /// \tThe id of the view to query.\n\t\t/// </summary>");
            interfaceContent.AppendLine("\t\tuint ViewId { get; }");
            interfaceContent.AppendLine("\t\t/// <summary>\n\t\t /// \tThe date of the record to query.\n\t\t/// </summary>");
            interfaceContent.AppendLine("\t\tSystem.DateTime RecordDate { get; }");

            var classContent = new StringBuilder();
            classContent.AppendLine("using LinqAn.Google.Metrics;\nusing LinqAn.Google.Dimensions;\n");
            classContent.AppendLine("namespace LinqAn.Google.Records");
            classContent.AppendLine("{");
            classContent.AppendLine("\tpublic class Record : IRecord");
            classContent.AppendLine("\t{\n\t\t/// <summary>\n\t\t /// \tThe id of the view to query.\n\t\t/// </summary>");
            classContent.AppendLine("\t\tpublic uint ViewId { get; set; }");
            classContent.AppendLine("\t\t/// <summary>\n\t\t /// \tThe date of the record to query.\n\t\t/// </summary>");
            classContent.AppendLine("\t\tpublic System.DateTime RecordDate { get; set; }");

            foreach (var column in columns)
            {
                var name = column.ToClassName();
                var description = column.Attributes.Description;

                interfaceContent.AppendLine($"\t\t/// <summary>\n\t\t/// \t{description}\n\t\t/// </summary>");
                interfaceContent.AppendLine($"\t\t{name} {name} {{ get; }}");

                classContent.AppendLine($"\t\t/// <summary>\n\t\t/// \t{description}\n\t\t/// </summary>");
                classContent.AppendLine($"\t\tpublic {name} {name} {{ get; set; }}");
            }

            interfaceContent.AppendLine("\t}\n}");
            classContent.AppendLine("\t}\n}");

            var filePath = $"{rootPath}\\IRecord.cs";
            var fileContent = interfaceContent;
            using (var tw = new StreamWriter(File.OpenWrite(filePath)))
            {
                tw.WriteLine(fileContent);
            }

            filePath = $"{rootPath}\\Record.cs";
            fileContent = classContent;
            using (var tw = new StreamWriter(File.OpenWrite(filePath)))
            {
                tw.WriteLine(fileContent);
            }
        }
    }
}