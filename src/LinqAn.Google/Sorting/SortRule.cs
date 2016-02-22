using System.ComponentModel;

namespace LinqAn.Google.Sorting
{
    public class SortRule : ISortRule
    {
        public string ColumnName { get; set; }
        public ListSortDirection SortDirection { get; set; }

        public override string ToString()
        {
            return (SortDirection == ListSortDirection.Descending ? "-" : "") + ColumnName;
        }
    }
}