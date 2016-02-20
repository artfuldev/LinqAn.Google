namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     A string. Corresponds to AdWords API Campaign.id.
    /// </summary>
    public class AdWordsCampaignID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdWordsCampaignID" />.
        /// </summary>
        public AdWordsCampaignID()
            : base(
                "AdWords Campaign ID", "A string. Corresponds to AdWords API Campaign.id.", false,
                "ga:adwordsCampaignID")
        {
        }
    }
}