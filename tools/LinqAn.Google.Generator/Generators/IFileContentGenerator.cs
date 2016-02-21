using System.Collections.Generic;
using LinqAn.Google.Generator.Core;

namespace LinqAn.Google.Generator.Generators
{
    public interface IFileContentGenerator
    {
        void GenerateFiles(string rootPath, IEnumerable<Column> columns);
        void GenerateFiles(string rootPath, IEnumerable<Column> columns, bool clearFiles, params string[] exclusions);
    }
}