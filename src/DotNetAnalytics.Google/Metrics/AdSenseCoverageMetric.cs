namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The percentage of ad requests that returned at least one ad.
    /// </summary>
    public class AdSenseCoverageMetric : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdSenseCoverageMetric" />.
        /// </summary>
        public AdSenseCoverageMetric()
            : base(
                "AdSense Coverage", "The percentage of ad requests that returned at least one ad.", false,
                "ga:adsenseCoverage")
        {
        }
    }
}