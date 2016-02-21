using System.Collections.Generic;
using LinqAn.Google.Generator.Core;

namespace LinqAn.Google.Generator
{
    public class MetaData
    {
        public string Kind { get; set; }
        public string Etag { get; set; }
        public int TotalResults { get; set; }
        public List<string> AttributeNames { get; set; }
        public List<Column> Items { get; set; }
    }
}
