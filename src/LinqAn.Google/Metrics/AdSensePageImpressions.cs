namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units.
    /// </summary>
    public class AdSensePageImpressions : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSensePageImpressions" />.
        /// </summary>
        public AdSensePageImpressions()
            : base(
                "AdSense Page Impressions",
                "The number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units.",
                true, "ga:adsensePageImpressions")
        {
        }
    }
}