using System;
using System.Text;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Filters;
using LinqAn.Google.Metrics;

namespace LinqAn.Google.Extensions
{
    public static class FilterExtensions
    {
        public static string ToStringRepresentation(this CombineOperator op)
        {
            switch (op)
            {
                case CombineOperator.None:
                    return "";
                case CombineOperator.And:
                    return ";";
                case CombineOperator.Or:
                    return ",";
                default:
                    throw new ArgumentOutOfRangeException(nameof(op), op, null);
            }
        }

        public static string ToStringRepresentation(this Operator op)
        {
            switch (op)
            {
                case Operator.None:
                    return "";
                case Operator.Equals:
                    return "==";
                case Operator.DoesNotEqual:
                    return "!=";
                case Operator.Contains:
                    return "=@";
                case Operator.DoesNotContain:
                    return "!@";
                case Operator.EqualsRegex:
                    return "=~";
                case Operator.DoesNotEqualRegex:
                    return "!~";
                case Operator.LessThan:
                    return "<";
                case Operator.LessThanOrEqualTo:
                    return "<=";
                case Operator.GreaterThan:
                    return ">";
                case Operator.GreaterThanOrEqualTo:
                    return ">=";
                default:
                    throw new ArgumentOutOfRangeException(nameof(op), op, null);
            }
        }

        public static string ToStringRepresentation(this IFilter filter)
        {
            var dimension = filter.DimensionOrMetric as IDimension;
            if (dimension == null)
            {
            }
            return dimension.Id + filter.Operator.ToStringRepresentation() + filter.Expression;
        }

        public static string ToStringRepresentation(this IFilterGroup filterGroup)
        {
            return filterGroup.Operator.ToStringRepresentation() + filterGroup.Filter.ToStringRepresentation();
        }

        public static string ToStringRepresentation(this IFilters filters)
        {
            var returnable = new StringBuilder();
            foreach (var filterGroup in filters.FilterGroups)
                returnable.Append(filterGroup.ToStringRepresentation());
            return returnable.ToString();
        }
    }
}