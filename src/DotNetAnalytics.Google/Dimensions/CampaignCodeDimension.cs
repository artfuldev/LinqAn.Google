namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     When using manual campaign tracking, the value of the utm_id campaign tracking parameter.
    /// </summary>
    public class CampaignCodeDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="CampaignCodeDimension" />.
        /// </summary>
        public CampaignCodeDimension()
            : base(
                "Campaign Code",
                "When using manual campaign tracking, the value of the utm_id campaign tracking parameter.", false,
                "ga:campaignCode")
        {
        }
    }
}