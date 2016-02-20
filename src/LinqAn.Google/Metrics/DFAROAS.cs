namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     DCM Return On Ad Spend (ROAS) (premium only).
    /// </summary>
    public class DFAROAS : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFAROAS" />.
        /// </summary>
        public DFAROAS() : base("DFA ROAS", "DCM Return On Ad Spend (ROAS) (premium only).", false, "ga:dcmROAS")
        {
        }
    }
}