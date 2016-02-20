using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LinqAn.Google.Generator.Generators
{
    public abstract class FileContentGenerator : IFileContentGenerator
    {
        public void GenerateFiles(string rootPath, IEnumerable<Column> columns, params string[] exclusions)
        {
            Directory.CreateDirectory(rootPath);
            var allFiles = new DirectoryInfo(rootPath).GetFiles();
            exclusions = exclusions ?? new string[0];
            var files = allFiles.Where(x => !exclusions.Contains(x.Name));
            foreach (var file in files)
                file.Delete();
            foreach (var column in columns)
            {
                var name = GetFileName(column);
                var filePath = $"{rootPath}\\{name}.cs";
                var fileContent = GenerateFileContent(column);
                using (var tw = new StreamWriter(File.OpenWrite(filePath)))
                {
                    tw.WriteLine(fileContent);
                }
            }
        }

        protected abstract string GetFileName(Column column);
        protected abstract string GenerateFileContent(Column column);
    }
}