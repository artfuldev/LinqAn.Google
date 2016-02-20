namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     DCM Floodlight revenue (premium only).
    /// </summary>
    public class DFARevenue : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFARevenue" />.
        /// </summary>
        public DFARevenue()
            : base("DFA Revenue", "DCM Floodlight revenue (premium only).", false, "ga:dcmFloodlightRevenue")
        {
        }
    }
}