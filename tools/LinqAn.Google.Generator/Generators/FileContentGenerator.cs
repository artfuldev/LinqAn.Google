using System.Collections.Generic;
using System.IO;
using System.Linq;
using LinqAn.Google.Generator.Core;

namespace LinqAn.Google.Generator.Generators
{
    public abstract class FileContentGenerator : IFileContentGenerator
    {
        public virtual void GenerateFiles(string rootPath, IEnumerable<ITypeInfo> typeInfos)
        {
            Directory.CreateDirectory(rootPath);
            foreach (var typeInfo in typeInfos)
            {
                var name = typeInfo.Id.GetClassName();
                var filePath = $"{rootPath}\\{name}.cs";
                var fileContent = GenerateFileContent(typeInfo);
                using (var tw = new StreamWriter(File.OpenWrite(filePath)))
                {
                    tw.WriteLine(fileContent);
                }
            }
        }

        public virtual void GenerateFiles(string rootPath, IEnumerable<ITypeInfo> typeInfos, bool clearFiles, params string[] exclusions)
        {
            Directory.CreateDirectory(rootPath);
            var allFiles = new DirectoryInfo(rootPath).GetFiles();
            exclusions = exclusions ?? new string[0];
            var files = allFiles.Where(x => !exclusions.Contains(x.Name));
            foreach (var file in files)
                file.Delete();
            GenerateFiles(rootPath, typeInfos);
        }
        protected virtual string GenerateFileContent(ITypeInfo typeInfo) => typeInfo.ToString();
    }
}