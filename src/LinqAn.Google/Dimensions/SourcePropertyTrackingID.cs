namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Source property tracking ID of roll-up properties. This is valid only for roll-up properties.
    /// </summary>
    public class SourcePropertyTrackingID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SourcePropertyTrackingID" />.
        /// </summary>
        public SourcePropertyTrackingID()
            : base(
                "Source Property Tracking ID",
                "Source property tracking ID of roll-up properties. This is valid only for roll-up properties.", true,
                "ga:sourcePropertyTrackingId")
        {
        }
    }
}