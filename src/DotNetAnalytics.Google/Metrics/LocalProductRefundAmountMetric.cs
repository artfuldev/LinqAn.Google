namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Refund amount for a given product in the local currency (Enhanced Ecommerce).
    /// </summary>
    public class LocalProductRefundAmountMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LocalProductRefundAmountMetric" />.
        /// </summary>
        public LocalProductRefundAmountMetric()
            : base(
                "Local Product Refund Amount",
                "Refund amount for a given product in the local currency (Enhanced Ecommerce).", true,
                "ga:localProductRefundAmount")
        {
        }
    }
}