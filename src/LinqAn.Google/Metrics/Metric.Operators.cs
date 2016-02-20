using System;
using System.Text.RegularExpressions;

namespace LinqAn.Google.Metrics
{
#pragma warning disable 660,661
    public abstract partial class Metric<T> : IMetric<T>
#pragma warning restore 660,661
    {
        public static bool operator ==(Metric<T> metric, T value)
        {
            if (ReferenceEquals(metric, value))
                return true;
            return !ReferenceEquals(metric, null) && Equals(metric.Value, value);
        }

        public static bool operator !=(Metric<T> metric, T value)
        {
            return !(metric == value);
        }

        public static bool operator ==(Metric<T> metric, Regex value)
        {
            return !ReferenceEquals(metric, null) && !ReferenceEquals(value, null) &&
                   value.IsMatch(metric.Value.ToString());
        }

        public static bool operator !=(Metric<T> metric, Regex value)
        {
            return !(metric == value);
        }

        public static bool operator <(Metric<T> metric, T value)
        {
            if (ReferenceEquals(metric, null))
                return false;
            if(typeof(T) == typeof(string))
                throw new InvalidOperationException("Cannot compare two strings in this fashion");
            return NumericallyLessThan(metric.Value, value);
        }

        public static bool operator >(Metric<T> metric, T value)
        {
            return !(metric < value) && metric != value;
        }

        public static bool operator <=(Metric<T> metric, T value)
        {
            return metric < value || metric == value;
        }

        public static bool operator >=(Metric<T> metric, T value)
        {
            return metric > value || metric == value;
        }

        private static bool NumericallyLessThan(object left, object right)
        {
            if (left is TimeSpan)
                return (TimeSpan) left < (TimeSpan) right;
            if (left is int || left is uint || left is decimal || left is double || left is float)
                return Convert.ToDecimal(left) < Convert.ToDecimal(right);
            return false;
        }
    }
}