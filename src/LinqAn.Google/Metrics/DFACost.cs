namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     DCM Total Cost (premium only).
    /// </summary>
    public class DFACost : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="DFACost" />.
        /// </summary>
        public DFACost() : base("DFA Cost", "DCM Total Cost (premium only).", false, "ga:dcmCost")
        {
        }
    }
}