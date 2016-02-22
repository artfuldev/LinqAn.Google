namespace LinqAn.Google.Filters
{
    internal interface IFilterGroup
    {
        CombineOperator Operator { get; }
        IFilter Filter { get; } 
    }
}