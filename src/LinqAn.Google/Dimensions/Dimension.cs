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
    }
}