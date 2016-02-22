using Org.BouncyCastle.Security.Certificates;

namespace LinqAn.Google.Filters
{
    internal interface IFilter
    {
        string DimensionOrMetric { get; }
        Operator Operator { get; }
        string Expression { get; }
    }
}