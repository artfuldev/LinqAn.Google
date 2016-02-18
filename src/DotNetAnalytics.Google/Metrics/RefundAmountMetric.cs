namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Currency amount refunded for a transaction (Enhanced Ecommerce).
    /// </summary>
    public class RefundAmountMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="RefundAmountMetric" />.
        /// </summary>
        public RefundAmountMetric()
            : base(
                "Refund Amount", "Currency amount refunded for a transaction (Enhanced Ecommerce).", true,
                "ga:refundAmount")
        {
        }
    }
}