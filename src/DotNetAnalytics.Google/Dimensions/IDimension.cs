using DotNetAnalytics.Google.Core;
using DotNetAnalytics.Google.Metrics;

namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Represents a dimension of type <see cref="T" /> in Google Analytics which is used to tag measurements.
    /// </summary>
    /// <typeparam name="T">The type of value this dimension holds.</typeparam>
    public interface IDimension<T> : IDescribable, ISupportSegmentation, IIndexable
    {
        /// <summary>
        ///     The value measured by this <seealso cref="IMetric{T}" />.
        /// </summary>
        T Value { get; set; }
    }
}