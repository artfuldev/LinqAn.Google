namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The networks used to deliver your ads (Content, Search, Search partners, etc.).
    /// </summary>
    public class AdDistributionNetwork : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdDistributionNetwork" />.
        /// </summary>
        public AdDistributionNetwork()
            : base(
                "Ad Distribution Network",
                "The networks used to deliver your ads (Content, Search, Search partners, etc.).", false,
                "ga:adDistributionNetwork")
        {
        }
    }
}