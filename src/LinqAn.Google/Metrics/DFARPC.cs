namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     DCM Revenue Per Click (premium only).
    /// </summary>
    public class DFARPC : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFARPC" />.
        /// </summary>
        public DFARPC() : base("DFA RPC", "DCM Revenue Per Click (premium only).", false, "ga:dcmRPC")
        {
        }
    }
}