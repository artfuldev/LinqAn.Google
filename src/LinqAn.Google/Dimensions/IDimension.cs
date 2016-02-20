using LinqAn.Google.Core;

namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Represents a dimension of type <see cref="T" /> in Google Analytics which is used to tag measurements.
    /// </summary>
    /// <typeparam name="T">The type of value this dimension holds.</typeparam>
    public interface IDimension<T> : IDimension
    {
        /// <summary>
        ///     The value of this <seealso cref="IDimension{T}" />.
        /// </summary>
        T Value { get; set; }
    }

    /// <summary>
    ///     Represents a dimension in Google Analytics which is used to tag measurements.
    /// </summary>
    public interface IDimension : IDescribable, ISupportSegmentation, IIndexable
    {
    }
}