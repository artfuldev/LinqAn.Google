namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total number of transactions divided by the total number of users.
    /// </summary>
    public class TransactionsPerUser : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="TransactionsPerUser" />.
        /// </summary>
        public TransactionsPerUser()
            : base(
                "Transactions per User", "The total number of transactions divided by the total number of users.", false,
                "ga:transactionsPerUser")
        {
        }
    }
}