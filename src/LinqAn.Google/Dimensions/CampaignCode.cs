namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     When using manual campaign tracking, the value of the utm_id campaign tracking parameter.
    /// </summary>
    public class CampaignCode : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="CampaignCode" />.
        /// </summary>
        public CampaignCode()
            : base(
                "Campaign Code",
                "When using manual campaign tracking, the value of the utm_id campaign tracking parameter.", false,
                "ga:campaignCode")
        {
        }
    }
}