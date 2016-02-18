namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Total refund amount for the transaction in the local currency (Enhanced Ecommerce).
    /// </summary>
    public class LocalRefundAmountMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LocalRefundAmountMetric" />.
        /// </summary>
        public LocalRefundAmountMetric()
            : base(
                "Local Refund Amount",
                "Total refund amount for the transaction in the local currency (Enhanced Ecommerce).", true,
                "ga:localRefundAmount")
        {
        }
    }
}