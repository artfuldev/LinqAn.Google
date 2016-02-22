using System.Collections.Generic;

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
    }
}