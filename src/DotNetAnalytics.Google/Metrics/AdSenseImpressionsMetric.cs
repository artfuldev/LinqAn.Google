namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit.
    /// </summary>
    public class AdSenseImpressionsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSenseImpressionsMetric" />.
        /// </summary>
        public AdSenseImpressionsMetric()
            : base(
                "AdSense Impressions",
                "The number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit.", true,
                "ga:adsenseAdsViewed")
        {
        }
    }
}