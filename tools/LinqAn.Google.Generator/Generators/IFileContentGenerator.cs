using System.Collections.Generic;

namespace LinqAn.Google.Generator.Generators
{
    public interface IFileContentGenerator
    {
        void GenerateFiles(string rootPath, IEnumerable<Column> columns, params string[] exclusions);
    }
}