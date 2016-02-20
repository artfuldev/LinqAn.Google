namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Transaction tax in local currency.
    /// </summary>
    public class LocalTax : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LocalTax" />.
        /// </summary>
        public LocalTax() : base("Local Tax", "Transaction tax in local currency.", false, "ga:localTransactionTax")
        {
        }
    }
}