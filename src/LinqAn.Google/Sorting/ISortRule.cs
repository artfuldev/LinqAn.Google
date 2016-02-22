using System.ComponentModel;

namespace LinqAn.Google.Sorting
{
    internal interface ISortRule
    {
        string ColumnName { get; }
        ListSortDirection SortDirection { get; }
    }
}