using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using ExpressionVisitor = LinqAn.Google.Linq.Core.ExpressionVisitor;

namespace LinqAn.Google.Linq.Queryables
{
    internal class ColumnProjector : ExpressionVisitor
    {
        private StringBuilder _columns;
        private int _iterator;
        private ParameterExpression _row;
        private static MethodInfo _getValue;

        internal ColumnProjector()
        {
            if (_getValue == null)
            {
                _getValue = typeof(ProjectionRow).GetMethod("GetValue");
            }
        }

        internal ColumnProjection ProjectColumns(Expression expression, ParameterExpression row)
        {
            _columns = new StringBuilder();
            _row = row;
            var selector = Visit(expression);
            return new ColumnProjection { Columns = _columns.ToString(), Selector = selector };
        }

        protected override Expression VisitMemberAccess(MemberExpression m)
        {
            if (m.Expression == null || m.Expression.NodeType != ExpressionType.Parameter)
                return base.VisitMemberAccess(m);
            if (_columns.Length > 0)
            {
                _columns.Append(", ");
            }
            _columns.Append(m.Member.Name);
            return Expression.Convert(Expression.Call(_row, _getValue, Expression.Constant(_iterator++)), m.Type);
        }
    }
}