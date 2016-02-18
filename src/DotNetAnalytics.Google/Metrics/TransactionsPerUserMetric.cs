namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total number of transactions divided by the total number of users.
    /// </summary>
    public class TransactionsPerUserMetric : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TransactionsPerUserMetric" />.
        /// </summary>
        public TransactionsPerUserMetric()
            : base(
                "Transactions per User", "The total number of transactions divided by the total number of users.", false,
                "ga:transactionsPerUser")
        {
        }
    }
}