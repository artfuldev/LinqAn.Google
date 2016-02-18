namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total number of transactions.
    /// </summary>
    public class TransactionsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TransactionsMetric" />.
        /// </summary>
        public TransactionsMetric() : base("Transactions", "The total number of transactions.", true, "ga:transactions")
        {
        }
    }
}