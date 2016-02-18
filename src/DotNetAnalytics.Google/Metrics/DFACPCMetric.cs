namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     DCM Cost Per Click (premium only).
    /// </summary>
    public class DFACPCMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACPCMetric" />.
        /// </summary>
        public DFACPCMetric() : base("DFA CPC", "DCM Cost Per Click (premium only).", false, "ga:dcmCPC")
        {
        }
    }
}