namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     DCM Total Clicks (premium only).
    /// </summary>
    public class DFAClicksMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAClicksMetric" />.
        /// </summary>
        public DFAClicksMetric() : base("DFA Clicks", "DCM Total Clicks (premium only).", false, "ga:dcmClicks")
        {
        }
    }
}