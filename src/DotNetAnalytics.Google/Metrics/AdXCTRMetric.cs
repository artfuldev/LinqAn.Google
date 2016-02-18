namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The percentage of pageviews that resulted in a click on an AdX ad.
    /// </summary>
    public class AdXCTRMetric : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdXCTRMetric" />.
        /// </summary>
        public AdXCTRMetric()
            : base("AdX CTR", "The percentage of pageviews that resulted in a click on an AdX ad.", false, "ga:adxCTR")
        {
        }
    }
}