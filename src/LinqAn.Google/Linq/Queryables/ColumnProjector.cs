using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using ExpressionVisitor = LinqAn.Google.Linq.Core.ExpressionVisitor;

namespace LinqAn.Google.Linq.Queryables
{
    internal class ColumnProjector : ExpressionVisitor
    {
        StringBuilder sb;
        int iColumn;
        ParameterExpression row;
        static MethodInfo miGetValue;

        internal ColumnProjector()
        {
            if (miGetValue == null)
            {
                miGetValue = typeof(ProjectionRow).GetMethod("GetValue");
            }
        }

        internal ColumnProjection ProjectColumns(Expression expression, ParameterExpression row)
        {
            sb = new StringBuilder();
            this.row = row;
            var selector = Visit(expression);
            return new ColumnProjection { Columns = sb.ToString(), Selector = selector };
        }

        protected override Expression VisitMemberAccess(MemberExpression m)
        {
            if (m.Expression == null || m.Expression.NodeType != ExpressionType.Parameter)
                return base.VisitMemberAccess(m);
            if (sb.Length > 0)
            {
                sb.Append(", ");
            }
            sb.Append(m.Member.Name);
            return Expression.Convert(Expression.Call(row, miGetValue, Expression.Constant(iColumn++)), m.Type);
        }
    }
}