namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     An AdX ad impression is reported whenever an individual ad is displayed on your website. For example, if a page
    ///     with two ad units is viewed once, we'll display two impressions.
    /// </summary>
    public class AdXImpressionsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdXImpressionsMetric" />.
        /// </summary>
        public AdXImpressionsMetric()
            : base(
                "AdX Impressions",
                "An AdX ad impression is reported whenever an individual ad is displayed on your website. For example, if a page with two ad units is viewed once, we'll display two impressions.",
                true, "ga:adxImpressions")
        {
        }
    }
}