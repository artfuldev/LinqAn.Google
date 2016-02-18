namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total estimated revenue from AdX ads per 1000 Analytics sessions. Note that this metric is based on sessions to
    ///     your site and not ad impressions.
    /// </summary>
    public class AdXRevenue1000SessionsMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AdXRevenue1000SessionsMetric" />.
        /// </summary>
        public AdXRevenue1000SessionsMetric()
            : base(
                "AdX Revenue / 1000 Sessions",
                "The total estimated revenue from AdX ads per 1000 Analytics sessions. Note that this metric is based on sessions to your site and not ad impressions.",
                false, "ga:adxRevenuePer1000Sessions")
        {
        }
    }
}