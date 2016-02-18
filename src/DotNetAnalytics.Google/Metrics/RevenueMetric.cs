namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total sale revenue provided in the transaction excluding shipping and tax.
    /// </summary>
    public class RevenueMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="RevenueMetric" />.
        /// </summary>
        public RevenueMetric()
            : base(
                "Revenue", "The total sale revenue provided in the transaction excluding shipping and tax.", true,
                "ga:transactionRevenue")
        {
        }
    }
}