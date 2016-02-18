namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Correlation Score for related products.
    /// </summary>
    public class CorrelationScoreMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="CorrelationScoreMetric" />.
        /// </summary>
        public CorrelationScoreMetric()
            : base("Correlation Score", "Correlation Score for related products.", false, "ga:correlationScore")
        {
        }
    }
}