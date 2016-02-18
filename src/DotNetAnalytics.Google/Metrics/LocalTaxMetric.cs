namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Transaction tax in local currency.
    /// </summary>
    public class LocalTaxMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LocalTaxMetric" />.
        /// </summary>
        public LocalTaxMetric()
            : base("Local Tax", "Transaction tax in local currency.", false, "ga:localTransactionTax")
        {
        }
    }
}