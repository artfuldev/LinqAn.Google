using System.Collections.Generic;
using System.Linq;

namespace LinqAn.Google.Filters
{
    internal class Filters : IFilters
    {
        private List<IFilterGroup> _filterGroupsList;

        public List<IFilterGroup> FilterGroupsList
        {
            get { return _filterGroupsList ?? (_filterGroupsList = new List<IFilterGroup>()); }
            set { _filterGroupsList = value; }
        }

        public IEnumerable<IFilterGroup> FilterGroups => FilterGroupsList;

        public override string ToString()
        {
            return FilterGroups.Aggregate("", (current, filterGroup) => current + filterGroup).TrimStart(';');
        }

        public void Add(IFilter filter, CombineOperator op = CombineOperator.None)
        {
            FilterGroupsList.Add(new FilterGroup() {Filter = filter, Operator = op});
        }
    }
}