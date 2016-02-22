using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Filters;
using LinqAn.Google.Linq.RecordQueries;
using LinqAn.Google.Metrics;
using ExpressionVisitor = LinqAn.Google.Linq.Core.ExpressionVisitor;

namespace LinqAn.Google.Linq.Queryables
{
    internal class RecordsQueryTranslator : ExpressionVisitor
    {
        private readonly QueryableRecordQuery _query;

        internal RecordsQueryTranslator()
        {
            _query = new QueryableRecordQuery();
        }

        internal QueryableRecordQuery Translate(Expression expression)
        {
            Visit(expression);
            return _query;
        }

        private static Expression StripQuotes(Expression e)
        {
            while (e.NodeType == ExpressionType.Quote)
            {
                e = ((UnaryExpression) e).Operand;
            }
            return e;
        }

        protected override Expression VisitMethodCall(MethodCallExpression m)
        {
            if (m.Method.DeclaringType != typeof (Queryable))
                throw new NotSupportedException($"The method '{m.Method.Name}' is not supported");

            switch (m.Method.Name)
            {
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
                        var startIndex = (int) skip.Value + 1;
                        _query.StartIndex = Convert.ToUInt32(startIndex);
                    }
                    break;
                case "Take":
                    Visit(m.Arguments[0]);
                    var take = m.Arguments[1] as ConstantExpression;
                    if (take != null)
                    {
                        var recordsCount = (int) take.Value;
                        _query.RecordsCount = Convert.ToUInt32(recordsCount);
                        _query.QueryAll = false;
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

        private void UpdateQuery(Expression left, Expression right, ExpressionType nodeType)
        {
            // x=>x.Property==constant, Reverse call if otherwise
            var memberExpression = left as MemberExpression;
            var constantExpression = right as ConstantExpression;
            if (memberExpression == null || constantExpression == null)
            {
                if (!(left is ConstantExpression) || !(right is MemberExpression))
                    throw new InvalidOperationException("one should be member, other should be constant");
                UpdateQuery(right, left, Reverse(nodeType));
                return;
            }

            var member = memberExpression.Member;
            switch (member.Name)
            {
                case "ViewId":
                    if (nodeType != ExpressionType.Equal)
                        throw new InvalidOperationException("ViewId can only be queried for Equal condition.");
                    _query.ViewId = (uint) constantExpression.Value;
                    return;
                case "RecordDate":
                    switch (nodeType)
                    {
                        case ExpressionType.Equal:
                        case ExpressionType.GreaterThanOrEqual:
                            _query.StartDate = (DateTime) constantExpression.Value;
                            return;
                        case ExpressionType.GreaterThan:
                            _query.StartDate = ((DateTime)constantExpression.Value).AddDays(1);
                            return;
                        case ExpressionType.LessThan:
                            _query.OptionalEndDate = ((DateTime)constantExpression.Value).AddDays(-1);
                            return;
                        case ExpressionType.LessThanOrEqual:
                            _query.OptionalEndDate = (DateTime) constantExpression.Value;
                            return;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(nodeType),
                                "Expression type has to be ==,>,<,>=, or <= for record date.");
                    }
                default:
                    // All other cases, where member name is a dimension or a metric
                    var propertyType = ((PropertyInfo)member).PropertyType;
                    if (typeof (IDimension).IsAssignableFrom(propertyType))
                    {
                        switch (nodeType)
                        {
                            case ExpressionType.Equal:
                            case ExpressionType.NotEqual:
                                _query.FiltersList.Add(
                                    new Filter(propertyType, GetOperator(nodeType), constantExpression.Value.ToString()),
                                    CombineOperator.And);
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(nodeType),
                                $"Expression type has to be == or != for {member.Name}.");
                        }
                    }
                    else if (typeof (IMetric).IsAssignableFrom(propertyType))
                    {
                        switch (nodeType)
                        {
                            case ExpressionType.Equal:
                            case ExpressionType.NotEqual:
                            case ExpressionType.LessThan:
                            case ExpressionType.LessThanOrEqual:
                            case ExpressionType.GreaterThan:
                            case ExpressionType.GreaterThanOrEqual:
                                _query.FiltersList.Add(
                                    new Filter(propertyType, GetOperator(nodeType), constantExpression.Value.ToString()),
                                    CombineOperator.And);
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(nodeType),
                                    $"Expression type has to be == or != for {member.Name}.");
                        }
                    }
                    throw new NotSupportedException("Only dimensions and metrics are allowed in filters.");
            }
        }

        private static Operator GetOperator(ExpressionType type, object value = null)
        {
            switch (type)
            {
                case ExpressionType.Equal:
                    return (value?.GetType() ?? typeof (object)) == typeof (Regex)
                        ? Operator.EqualsRegex
                        : Operator.Equals;
                case ExpressionType.NotEqual:
                    return (value?.GetType() ?? typeof(object)) == typeof(Regex)
                        ? Operator.DoesNotEqualRegex
                        : Operator.DoesNotEqual;
                case ExpressionType.LessThan:
                    return Operator.LessThan;
                case ExpressionType.LessThanOrEqual:
                    return Operator.LessThanOrEqualTo;
                case ExpressionType.GreaterThan:
                    return Operator.GreaterThan;
                case ExpressionType.GreaterThanOrEqual:
                    return Operator.GreaterThanOrEqualTo;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type),
                        $"Expression type cannot be converted into operator for Google Analytics.");
            }
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