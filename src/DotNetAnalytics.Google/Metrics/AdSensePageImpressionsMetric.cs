namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units.
    /// </summary>
    public class AdSensePageImpressionsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSensePageImpressionsMetric" />.
        /// </summary>
        public AdSensePageImpressionsMetric()
            : base(
                "AdSense Page Impressions",
                "The number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units.",
                true, "ga:adsensePageImpressions")
        {
        }
    }
}