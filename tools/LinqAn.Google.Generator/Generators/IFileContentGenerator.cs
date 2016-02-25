using System.Collections.Generic;
using LinqAn.Google.Generator.Core;

namespace LinqAn.Google.Generator.Generators
{
    public interface IFileContentGenerator
    {
        void GenerateFiles(string rootPath, IEnumerable<ITypeInfo> typeInfos);
        void GenerateFiles(string rootPath, IEnumerable<ITypeInfo> typeInfos, bool clearFiles, params string[] exclusions);
    }
}