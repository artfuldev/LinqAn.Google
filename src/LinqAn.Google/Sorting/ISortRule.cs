using System.ComponentModel;

namespace LinqAn.Google.Sorting
{
    public interface ISortRule
    {
        string ColumnName { get; }
        ListSortDirection SortDirection { get; }
    }
}