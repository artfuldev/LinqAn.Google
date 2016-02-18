using System.Collections.Generic;

namespace DotNetAnalytics.Google.Generator
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
