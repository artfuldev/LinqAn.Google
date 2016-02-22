namespace LinqAn.Google.Filters
{
    public interface IFilterGroup
    {
        CombineOperator Operator { get; }
        IFilter Filter { get; } 
    }
}