using System.Collections.Generic;
using System.IO;
using System.Linq;
using LinqAn.Google.Generator.Core;

namespace LinqAn.Google.Generator.Generators
{
    public abstract class FileContentGenerator : IFileContentGenerator
    {
        public virtual void GenerateFiles(string rootPath, IEnumerable<Column> columns)
        {
            Directory.CreateDirectory(rootPath);
            foreach (var column in columns)
            {
                var name = column.ToClassName();
                var filePath = $"{rootPath}\\{name}.cs";
                var fileContent = GenerateFileContent(column);
                using (var tw = new StreamWriter(File.OpenWrite(filePath)))
                {
                    tw.WriteLine(fileContent);
                }
            }
        }

        public virtual void GenerateFiles(string rootPath, IEnumerable<Column> columns, bool clearFiles, params string[] exclusions)
        {
            Directory.CreateDirectory(rootPath);
            var allFiles = new DirectoryInfo(rootPath).GetFiles();
            exclusions = exclusions ?? new string[0];
            var files = allFiles.Where(x => !exclusions.Contains(x.Name));
            foreach (var file in files)
                file.Delete();
            GenerateFiles(rootPath, columns);
        }
        protected virtual string GenerateFileContent(Column column) => column.ToString();
    }
}