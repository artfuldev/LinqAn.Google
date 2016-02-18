namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Number of product units refunded (Enhanced Ecommerce).
    /// </summary>
    public class QuantityRefundedMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="QuantityRefundedMetric" />.
        /// </summary>
        public QuantityRefundedMetric()
            : base(
                "Quantity Refunded", "Number of product units refunded (Enhanced Ecommerce).", true,
                "ga:quantityRefunded")
        {
        }
    }
}