namespace DotNetAnalytics.Google.Metrics
{
    public abstract class Metric<T> : IMetric<T>
    {
        protected Metric(string name, string description, bool allowedInSegments, string id)
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