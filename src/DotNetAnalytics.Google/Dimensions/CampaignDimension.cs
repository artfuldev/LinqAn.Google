namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     When using manual campaign tracking, the value of the utm_campaign campaign tracking parameter. When using AdWords
    ///     autotagging, the name(s) of the online ad campaign that you use for your property. Otherwise the value (not set) is
    ///     used.
    /// </summary>
    public class CampaignDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="CampaignDimension" />.
        /// </summary>
        public CampaignDimension()
            : base(
                "Campaign",
                "When using manual campaign tracking, the value of the utm_campaign campaign tracking parameter. When using AdWords autotagging, the name(s) of the online ad campaign that you use for your property. Otherwise the value (not set) is used.",
                true, "ga:campaign")
        {
        }
    }
}