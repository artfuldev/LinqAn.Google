using LinqAn.Google.Core;

namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Represents a dimension in Google Analytics which is used to tag measurements.
    /// </summary>
    public interface IDimension : IIdentifiable, ISupportSegmentation, IIndexable
    {
        /// <summary>
        ///     The value of this <seealso cref="IDimension" />.
        /// </summary>
        string Value { get; set; }
    }
}