using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Filters;
using LinqAn.Google.Linq.RecordQueries;
using LinqAn.Google.Metrics;
using LinqAn.Google.Records;
using LinqAn.Google.Sorting;
using ExpressionVisitor = LinqAn.Google.Linq.Core.ExpressionVisitor;

namespace LinqAn.Google.Linq.Queryables
{
    internal class RecordsQueryTranslator : ExpressionVisitor
    {
        private QueryableRecordQuery _query;
        private CombineOperator _combineOperator;
        private LambdaExpression _selector;

        internal TranslateResult Translate(Expression expression)
        {
            _query = new QueryableRecordQuery();
            _combineOperator = CombineOperator.And;

            Visit(expression);
            return new TranslateResult
            {
                Query = _query,
                Selector = _selector
            };
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
            var declaringType = m.Method.DeclaringType;
            if (declaringType != typeof (Queryable) &&
                !typeof (IMetric).IsAssignableFrom(declaringType) &&
                !typeof (IDimension).IsAssignableFrom(declaringType))
                throw new NotSupportedException($"The method '{m.Method.Name}' is not supported");

            switch (m.Method.Name)
            {
                case "Where":
                    _combineOperator = CombineOperator.And;
                    Visit(m.Arguments[0]);
                    var lambda = (LambdaExpression) StripQuotes(m.Arguments[1]);
                    Visit(lambda.Body);
                    break;
                case "OrderBy":
                case "OrderByDescending":
                case "ThenBy":
                case "ThenByDescending":
                    Visit(m.Arguments[0]);
                    var direction = m.Method.Name.Contains("Descending")
                        ? ListSortDirection.Descending
                        : ListSortDirection.Ascending;
                    // TODO: replace column name
                    var unaryExpression = m.Arguments[1] as UnaryExpression;
                    var operand = unaryExpression?.Operand;
                    var memberEx = operand?.GetType()?.GetRuntimeProperty("Body")?.GetValue(operand) as MemberExpression;
                    var info = memberEx?.Member as PropertyInfo;
                    var propertyType = info?.PropertyType;
                    if (propertyType == null
                        || (!typeof (IDimension).IsAssignableFrom(propertyType)
                            && !typeof (IMetric).IsAssignableFrom(propertyType)))
                        throw new NotSupportedException($"The method '{m.Method.Name}' is not supported");
                    _query.SortRulesList.Add(new SortRule(propertyType, direction));
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
                case "Contains":
                    var memberExpression = m.Object as MemberExpression;
                    var propertyInfo = memberExpression?.Member as PropertyInfo;
                    var dimensionType = propertyInfo?.PropertyType;
                    if(dimensionType == null || !typeof (IDimension).IsAssignableFrom(dimensionType))
                        throw new NotSupportedException($"The method '{m.Method.Name}' is not supported");
                    var expression = m.Arguments.First() as ConstantExpression;
                    var value = expression?.Value?.ToString();
                    if (string.IsNullOrWhiteSpace(value))
                        break;
                    _query.FiltersList.Add(new Filter(dimensionType, Operator.Contains, value), _combineOperator);
                    break;
                case "Select":
                    var lambdaExpression = (LambdaExpression)StripQuotes(m.Arguments[1]);
                    Visit(m.Arguments[0]);
                    _selector = lambdaExpression;
                    break;
                default:
                    throw new NotSupportedException($"The method '{m.Method.Name}' is not supported");
            }
            return m;
        }

        protected override Expression VisitUnary(UnaryExpression u)
        {
            if (u.NodeType != ExpressionType.Not)
                throw new NotSupportedException($"The unary operator '{u.NodeType}' is not supported");
            var m = u.Operand as MethodCallExpression;
            var declaringType = m?.Method?.DeclaringType;
            if (declaringType == null ||
                !typeof (IMetric).IsAssignableFrom(declaringType) &&
                !typeof (IDimension).IsAssignableFrom(declaringType))
                throw new NotSupportedException($"The unary operator '{u.NodeType}' is not supported");
            var memberExpression = m.Object as MemberExpression;
            var propertyInfo = memberExpression?.Member as PropertyInfo;
            var dimensionType = propertyInfo?.PropertyType;
            if (dimensionType == null || !typeof(IDimension).IsAssignableFrom(dimensionType))
                throw new NotSupportedException($"The method '{m.Method.Name}' is not supported");
            var expression = m.Arguments.First() as ConstantExpression;
            var value = expression?.Value?.ToString();
            if (string.IsNullOrWhiteSpace(value))
                return u;
            _query.FiltersList.Add(new Filter(dimensionType, Operator.DoesNotContain, value), _combineOperator);
            return u;
        }

        protected override Expression VisitBinary(BinaryExpression b)
        {
            switch (b.NodeType)
            {
                case ExpressionType.AndAlso:
                    Visit(b.Left);
                    _combineOperator = CombineOperator.And;
                    break;
                case ExpressionType.OrElse:
                    Visit(b.Left);
                    _combineOperator = CombineOperator.Or;
                    break;
                case ExpressionType.NotEqual:
                case ExpressionType.Equal:
                case ExpressionType.LessThan:
                case ExpressionType.LessThanOrEqual:
                case ExpressionType.GreaterThan:
                case ExpressionType.GreaterThanOrEqual:
                    UpdateQuery(b.Left, b.Right, b.NodeType);
                    _combineOperator = CombineOperator.And;
                    return b;
                default:
                    throw new NotSupportedException($"The binary operator '{b.NodeType}' is not supported");
            }
            Visit(b.Right);
            _combineOperator = CombineOperator.And;
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
            var value = constantExpression.Value;
            switch (member.Name)
            {
                case "ViewId":
                    if (nodeType != ExpressionType.Equal)
                        throw new InvalidOperationException("ViewId can only be queried for Equal condition.");
                    _query.ViewId = (uint) value;
                    return;
                case "RecordDate":
                    switch (nodeType)
                    {
                        case ExpressionType.Equal:
                        case ExpressionType.GreaterThanOrEqual:
                            _query.StartDate = (DateTime) value;
                            return;
                        case ExpressionType.GreaterThan:
                            _query.StartDate = ((DateTime)value).AddDays(1);
                            return;
                        case ExpressionType.LessThan:
                            _query.OptionalEndDate = ((DateTime)value).AddDays(-1);
                            return;
                        case ExpressionType.LessThanOrEqual:
                            _query.OptionalEndDate = (DateTime) value;
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
                                    new Filter(propertyType, GetOperator(nodeType, value), value.ToString()),
                                    _combineOperator);
                                return;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(nodeType),
                                $"Expression type has to be == or != for {member.Name}.");
                        }
                    }
                    if (typeof (IMetric).IsAssignableFrom(propertyType))
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
                                    new Filter(propertyType, GetOperator(nodeType, value), GetFilterValue(value)),
                                    _combineOperator);
                                return;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(nodeType),
                                    $"Expression type has to be == or != for {member.Name}.");
                        }
                    }
                    throw new NotSupportedException("Only dimensions and metrics are allowed in filters.");
            }
        }

        private static string GetFilterValue(object value)
        {
            var type = value.GetType();
            if (type == typeof (TimeSpan))
                return ((TimeSpan) value).TotalSeconds.ToString(CultureInfo.InvariantCulture);
            return value.ToString();
        }

        private static Operator GetOperator(ExpressionType type, object value = null)
        {
            switch (type)
            {
                case ExpressionType.Equal:
                    return (value?.GetType() ?? typeof (object)) == typeof (Regex)
                        ? Operator.MatchesRegex
                        : Operator.Equals;
                case ExpressionType.NotEqual:
                    return (value?.GetType() ?? typeof(object)) == typeof(Regex)
                        ? Operator.DoesNotMatchRegex
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