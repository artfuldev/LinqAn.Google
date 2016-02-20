using System.Text.RegularExpressions;

namespace LinqAn.Google.Dimensions
{
#pragma warning disable 660,661
    public abstract partial class Dimension<T> : IDimension<T>
#pragma warning restore 660,661
    {
        public static bool operator ==(Dimension<T> dimension, T value)
        {
            if (ReferenceEquals(dimension, value))
                return true;
            return !ReferenceEquals(dimension, null) && Equals(dimension.Value, value);
        }

        public static bool operator !=(Dimension<T> dimension, T value)
        {
            return !(dimension == value);
        }

        public static bool operator ==(Dimension<T> dimension, Regex value)
        {
            return !ReferenceEquals(dimension, null) && !ReferenceEquals(value, null) &&
                   value.IsMatch(dimension.Value.ToString());
        }

        public static bool operator !=(Dimension<T> dimension, Regex value)
        {
            return !(dimension == value);
        }
    }
}