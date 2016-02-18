namespace DotNetAnalytics.Google.Core
{
    /// <summary>
    ///     Represents a metric in Google Analytics which measures measurements of type <see cref="T" />.
    /// </summary>
    /// <typeparam name="T">The type of measure this metric measures.</typeparam>
    public interface IMetric<T> : ISupportSegmentation
    {
        string Name { get; }
        string QueryName { get; }

    }
}