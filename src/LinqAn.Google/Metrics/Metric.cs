namespace LinqAn.Google.Metrics
{
#pragma warning disable 660,661
    public abstract class Metric<T> : IMetric<T>
#pragma warning restore 660,661
    {
        internal Metric(string name, string description, bool allowedInSegments, string id)
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