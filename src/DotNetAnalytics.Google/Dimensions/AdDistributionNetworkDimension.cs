namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The networks used to deliver your ads (Content, Search, Search partners, etc.).
    /// </summary>
    public class AdDistributionNetworkDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdDistributionNetworkDimension" />.
        /// </summary>
        public AdDistributionNetworkDimension()
            : base(
                "Ad Distribution Network",
                "The networks used to deliver your ads (Content, Search, Search partners, etc.).", false,
                "ga:adDistributionNetwork")
        {
        }
    }
}