using LinqAn.Google.Core;

namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Represents a metric in Google Analytics which measures measurements of type <see cref="T" />.
    /// </summary>
    /// <typeparam name="T">The type of measure this metric measures.</typeparam>
    internal interface IMetric<T> : IMetric
    {
        /// <summary>
        ///     The value measured by this <seealso cref="IMetric{T}" />.
        /// </summary>
        T Value { get; set; }
    }

    /// <summary>
    ///     Represents a metric in Google Analytics which measures measurements.
    /// </summary>
    internal interface IMetric : IIdentifiable, ISupportSegmentation, IIndexable
    {
    }
}