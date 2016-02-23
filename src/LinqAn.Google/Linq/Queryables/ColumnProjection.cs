using System.Linq.Expressions;

namespace LinqAn.Google.Linq.Queryables
{
    internal class ColumnProjection
    {
        internal string Columns;
        internal Expression Selector;
    }
}