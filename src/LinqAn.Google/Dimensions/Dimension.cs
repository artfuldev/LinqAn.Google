using System.Text.RegularExpressions;

namespace LinqAn.Google.Dimensions
{
#pragma warning disable 660,661
    public abstract class Dimension<T> : IDimension<T>
#pragma warning restore 660,661
    {
        internal Dimension(string name, string description, bool allowedInSegments, string id)
        {
            Name = name;
            Description = description;
            AllowedInSegments = allowedInSegments;
            Id = id;
        }

        public string Name { get; }
        public string Description { get; }
        public bool AllowedInSegments { get; }
        public string Id { get; }
        public T Value { get; set; }

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

        public override string ToString() => $"{Name} : {Value}";
    }
}