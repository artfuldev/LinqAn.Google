namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     DCM Cost Per Click (premium only).
    /// </summary>
    public class DFACPC : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACPC" />.
        /// </summary>
        public DFACPC() : base("DFA CPC", "DCM Cost Per Click (premium only).", false, "ga:dcmCPC")
        {
        }
    }
}