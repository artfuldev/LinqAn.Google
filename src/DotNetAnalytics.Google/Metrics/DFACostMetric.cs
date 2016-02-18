namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     DCM Total Cost (premium only).
    /// </summary>
    public class DFACostMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACostMetric" />.
        /// </summary>
        public DFACostMetric() : base("DFA Cost", "DCM Total Cost (premium only).", false, "ga:dcmCost")
        {
        }
    }
}