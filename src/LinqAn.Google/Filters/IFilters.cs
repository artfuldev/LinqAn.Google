using System.Collections.Generic;

namespace LinqAn.Google.Filters
{
    public interface IFilters
    {
        IEnumerable<IFilterGroup> FilterGroups { get; }  
    }
}