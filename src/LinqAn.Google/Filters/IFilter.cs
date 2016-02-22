using Org.BouncyCastle.Security.Certificates;

namespace LinqAn.Google.Filters
{
    public interface IFilter
    {
        string DimensionOrMetric { get; }
        Operator Operator { get; }
        string Expression { get; }
    }
}