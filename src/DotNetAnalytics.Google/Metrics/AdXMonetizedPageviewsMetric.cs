namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Monetized Pageviews measures the total number of pageviews on your property that were shown with an ad from your
    ///     linked AdX account. Note - a single page can have multiple ad units.
    /// </summary>
    public class AdXMonetizedPageviewsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdXMonetizedPageviewsMetric" />.
        /// </summary>
        public AdXMonetizedPageviewsMetric()
            : base(
                "AdX Monetized Pageviews",
                "Monetized Pageviews measures the total number of pageviews on your property that were shown with an ad from your linked AdX account. Note - a single page can have multiple ad units.",
                true, "ga:adxMonetizedPageviews")
        {
        }
    }
}