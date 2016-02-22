using System;
using System.ComponentModel;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Filters;
using LinqAn.Google.Metrics;

namespace LinqAn.Google.Sorting
{
    internal class SortRule : ISortRule
    {
        public SortRule(Type type, ListSortDirection direction)
        {
            if (!typeof (IDimension).IsAssignableFrom(type) && !typeof (IMetric).IsAssignableFrom(type))
                throw new ArgumentException("type must be derived from IDimension or IMetric", nameof(type));
            ColumnName = ((dynamic) Activator.CreateInstance(type)).Id.ToString();
            SortDirection = direction;
        }

        public string ColumnName { get; set; }
        public ListSortDirection SortDirection { get; set; }

        public override string ToString()
        {
            return (SortDirection == ListSortDirection.Descending ? "-" : "") + ColumnName;
        }
    }
}