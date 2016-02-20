namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is
    ///     used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.
    /// </summary>
    public class DOMLatencyMetricsSample : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DOMLatencyMetricsSample" />.
        /// </summary>
        public DOMLatencyMetricsSample()
            : base(
                "DOM Latency Metrics Sample",
                "The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.",
                false, "ga:domLatencyMetricsSample")
        {
        }
    }
}