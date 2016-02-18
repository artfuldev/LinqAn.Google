namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The percentage of impressions that were viewable.
    /// </summary>
    public class AdSenseViewableImpressionMetric : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSenseViewableImpressionMetric" />.
        /// </summary>
        public AdSenseViewableImpressionMetric()
            : base(
                "AdSense Viewable Impression %", "The percentage of impressions that were viewable.", false,
                "ga:adsenseViewableImpressionPercent")
        {
        }
    }
}