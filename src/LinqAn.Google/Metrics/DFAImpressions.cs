namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     DCM Total Impressions (premium only).
    /// </summary>
    public class DFAImpressions : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAImpressions" />.
        /// </summary>
        public DFAImpressions()
            : base("DFA Impressions", "DCM Total Impressions (premium only).", false, "ga:dcmImpressions")
        {
        }
    }
}