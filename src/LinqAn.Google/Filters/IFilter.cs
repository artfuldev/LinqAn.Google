namespace LinqAn.Google.Filters
{
    public interface IFilter
    {
        object DimensionOrMetric { get; }
        Operator Operator { get; }
        object Value { get; }
    }
}