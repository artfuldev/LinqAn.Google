namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The effective cost per thousand pageviews. It is your AdX Revenue per 1000 pageviews.
    /// </summary>
    public class AdXECPMMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdXECPMMetric" />.
        /// </summary>
        public AdXECPMMetric()
            : base(
                "AdX eCPM", "The effective cost per thousand pageviews. It is your AdX Revenue per 1000 pageviews.",
                false, "ga:adxECPM")
        {
        }
    }
}