namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     A string. Corresponds to AdWords API Campaign.id.
    /// </summary>
    public class AdWordsCampaignIDDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdWordsCampaignIDDimension" />.
        /// </summary>
        public AdWordsCampaignIDDimension()
            : base(
                "AdWords Campaign ID", "A string. Corresponds to AdWords API Campaign.id.", false,
                "ga:adwordsCampaignID")
        {
        }
    }
}