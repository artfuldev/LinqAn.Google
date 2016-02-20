namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The number of DCM Floodlight conversions (premium only).
    /// </summary>
    public class DFAConversions : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAConversions" />.
        /// </summary>
        public DFAConversions()
            : base(
                "DFA Conversions", "The number of DCM Floodlight conversions (premium only).", false,
                "ga:dcmFloodlightQuantity")
        {
        }
    }
}