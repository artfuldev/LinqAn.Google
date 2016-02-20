namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     DCM Click Through Rate (premium only).
    /// </summary>
    public class DFACTR : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACTR" />.
        /// </summary>
        public DFACTR() : base("DFA CTR", "DCM Click Through Rate (premium only).", false, "ga:dcmCTR")
        {
        }
    }
}