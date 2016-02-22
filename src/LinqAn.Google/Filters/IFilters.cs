using System.Collections.Generic;

namespace LinqAn.Google.Filters
{
    internal interface IFilters
    {
        IEnumerable<IFilterGroup> FilterGroups { get; }  
    }
}