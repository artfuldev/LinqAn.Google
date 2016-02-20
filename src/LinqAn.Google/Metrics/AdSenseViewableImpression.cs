namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The percentage of impressions that were viewable.
    /// </summary>
    public class AdSenseViewableImpression : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSenseViewableImpression" />.
        /// </summary>
        public AdSenseViewableImpression()
            : base(
                "AdSense Viewable Impression %", "The percentage of impressions that were viewable.", false,
                "ga:adsenseViewableImpressionPercent")
        {
        }
    }
}