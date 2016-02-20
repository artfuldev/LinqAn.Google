namespace LinqAn.Google.Core
{
    /// <summary>
    ///     An entity that supports segmentation in Google ANalytics.
    /// </summary>
    public interface ISupportSegmentation
    {
        /// <summary>
        ///     Represents if this item is allowed in segments.
        /// </summary>
        bool AllowedInSegments { get; }
    }
}