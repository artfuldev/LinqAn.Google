using System.Text.RegularExpressions;

namespace LinqAn.Google.Dimensions
{
#pragma warning disable 660,661
    public abstract class Dimension : IDimension
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
        public string Value { get; set; }

        public static bool operator ==(Dimension dimension, string value)
        {
            return ReferenceEquals(dimension, null) && value == null ||
                   !ReferenceEquals(dimension, null) && Equals(dimension.Value, value);
        }

        public static bool operator !=(Dimension dimension, string value)
        {
            return !(dimension == value);
        }

        public static bool operator ==(Dimension dimension, Regex value)
        {
            return !ReferenceEquals(dimension, null) && !ReferenceEquals(value, null) &&
                   value.IsMatch(dimension.Value);
        }

        public static bool operator !=(Dimension dimension, Regex value)
        {
            return !(dimension == value);
        }

        public bool Contains(string subString)
        {
            return Value?.Contains(subString) ?? false;
        }

        public override string ToString() => $"{Name} : {Value}";
    }
}