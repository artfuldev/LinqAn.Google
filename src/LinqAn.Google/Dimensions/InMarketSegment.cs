namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Indicates that users are more likely to be ready to purchase products or services in the specified category.
    /// </summary>
    public class InMarketSegment : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="InMarketSegment" />.
        /// </summary>
        public InMarketSegment()
            : base(
                "In-Market Segment",
                "Indicates that users are more likely to be ready to purchase products or services in the specified category.",
                false, "ga:interestInMarketCategory")
        {
        }
    }
}