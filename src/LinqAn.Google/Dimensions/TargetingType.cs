namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).
    /// </summary>
    public class TargetingType : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TargetingType" />.
        /// </summary>
        public TargetingType()
            : base(
                "Targeting Type",
                "How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).", true,
                "ga:adTargetingType")
        {
        }
    }
}