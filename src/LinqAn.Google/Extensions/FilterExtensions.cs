using System;
using System.Linq;
using System.Text;
using LinqAn.Google.Dimensions;
using LinqAn.Google.Filters;
using LinqAn.Google.Metrics;

namespace LinqAn.Google.Extensions
{
    internal static class FilterExtensions
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
                case Operator.MatchesRegex:
                    return "=~";
                case Operator.DoesNotMatchRegex:
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
    }
}