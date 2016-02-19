using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using ExpressionVisitor = DotNetAnalytics.Google.Linq.Core.ExpressionVisitor;

namespace DotNetAnalytics.Google.Linq.Queryables
{
    internal class RecordsQueryTranslator : ExpressionVisitor
    {
        private readonly IDictionary<string, string> _dictionary;

        internal RecordsQueryTranslator()
        {
            _dictionary = new Dictionary<string, string>();
        }

        internal IDictionary<string, string> Translate(Expression expression)
        {
            Visit(expression);
            return _dictionary;
        }

        private static Expression StripQuotes(Expression e)
        {
            while (e.NodeType == ExpressionType.Quote)
            {
                e = ((UnaryExpression)e).Operand;
            }
            return e;
        }

        protected override Expression VisitMethodCall(MethodCallExpression m)
        {
            if (m.Method.DeclaringType != typeof (Queryable))
                throw new NotSupportedException($"The method '{m.Method.Name}' is not supported");

            switch(m.Method.Name) {
                case "Where":
                    Visit(m.Arguments[0]);
                    var lambda = (LambdaExpression) StripQuotes(m.Arguments[1]);
                    Visit(lambda.Body);
                    break;
                case "OrderBy":
                case "OrderByDescending":
                    break;
                case "Skip":
                    Visit(m.Arguments[0]);
                    var skip = m.Arguments[1] as ConstantExpression;
                    if (skip != null)
                    {
                        var startIndex = (int)(skip.Value) + 1;
                    }
                    break;
                case "Take":
                    Visit(m.Arguments[0]);
                    var take = m.Arguments[1] as ConstantExpression;
                    if (take != null)
                    {
                        var recordsCount = (int)(take.Value);
                    }
                    break;
                default:
                    throw new NotSupportedException($"The method '{m.Method.Name}' is not supported");
            }
            return m;
        }

        protected override Expression VisitUnary(UnaryExpression u)
        {
            throw new NotSupportedException($"The unary operator '{u.NodeType}' is not supported");
        }

        protected override Expression VisitBinary(BinaryExpression b)
        {
            switch (b.NodeType)
            {
                case ExpressionType.And:
                case ExpressionType.Or:
                case ExpressionType.AndAlso:
                    Visit(b.Left);
                    break;
                case ExpressionType.NotEqual:
                    throw new NotSupportedException($"The binary operator '{b.NodeType}' is not supported");
                case ExpressionType.Equal:
                case ExpressionType.LessThan:
                case ExpressionType.LessThanOrEqual:
                case ExpressionType.GreaterThan:
                case ExpressionType.GreaterThanOrEqual:
                    UpdateQuery(b.Left, b.Right, b.NodeType);
                    return b;
                default:
                    throw new NotSupportedException($"The binary operator '{b.NodeType}' is not supported");
            }
            Visit(b.Right);
            return b;
        }

        private static void UpdateQuery(Expression left, Expression right, ExpressionType nodeType)
        {
            throw new NotImplementedException();
        }

        private static ExpressionType Reverse(ExpressionType eType)
        {
            switch (eType)
            {
                case ExpressionType.Equal:
                case ExpressionType.NotEqual:
                    return eType;
                case ExpressionType.LessThan:
                    return ExpressionType.GreaterThan;
                case ExpressionType.LessThanOrEqual:
                    return ExpressionType.GreaterThanOrEqual;
                case ExpressionType.GreaterThan:
                    return ExpressionType.LessThan;
                case ExpressionType.GreaterThanOrEqual:
                    return ExpressionType.LessThanOrEqual;
                default:
                    throw new NotSupportedException($"Only ==, !=, <, >, >=, <= operators are supported");
            }
        }
    }
}
