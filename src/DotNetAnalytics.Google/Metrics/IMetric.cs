using DotNetAnalytics.Google.Core;

namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Represents a metric in Google Analytics which measures measurements of type <see cref="T" />.
    /// </summary>
    /// <typeparam name="T">The type of measure this metric measures.</typeparam>
    public interface IMetric<T> : IDescribable, ISupportSegmentation, IIndexable
    {
        /// <summary>
        ///     The value measured by this <seealso cref="IMetric{T}" />.
        /// </summary>
        T Value { get; set; }
    }
}