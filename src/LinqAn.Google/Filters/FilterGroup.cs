using LinqAn.Google.Extensions;

namespace LinqAn.Google.Filters
{
    internal class FilterGroup : IFilterGroup
    {
        public CombineOperator Operator { get; set; } = CombineOperator.None;
        public IFilter Filter { get; set; }
        public override string ToString()
        {
            return Operator.ToStringRepresentation() + Filter;
        }
    }
}