namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Number of refunds that have been issued (Enhanced Ecommerce).
    /// </summary>
    public class Refunds : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Refunds" />.
        /// </summary>
        public Refunds()
            : base("Refunds", "Number of refunds that have been issued (Enhanced Ecommerce).", true, "ga:totalRefunds")
        {
        }
    }
}