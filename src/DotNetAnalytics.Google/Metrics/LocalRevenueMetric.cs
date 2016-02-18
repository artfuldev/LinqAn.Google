namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Transaction revenue in local currency.
    /// </summary>
    public class LocalRevenueMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LocalRevenueMetric" />.
        /// </summary>
        public LocalRevenueMetric()
            : base("Local Revenue", "Transaction revenue in local currency.", false, "ga:localTransactionRevenue")
        {
        }
    }
}