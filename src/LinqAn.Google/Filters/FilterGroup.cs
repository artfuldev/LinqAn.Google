namespace LinqAn.Google.Filters
{
    internal class FilterGroup : IFilterGroup
    {
        public CombineOperator Operator { get; set; } = CombineOperator.None;
        public IFilter Filter { get; set; }
    }
}