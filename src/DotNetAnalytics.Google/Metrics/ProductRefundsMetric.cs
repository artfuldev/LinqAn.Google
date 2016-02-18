namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Number of times a refund was issued for the product (Enhanced Ecommerce).
    /// </summary>
    public class ProductRefundsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductRefundsMetric" />.
        /// </summary>
        public ProductRefundsMetric()
            : base(
                "Product Refunds", "Number of times a refund was issued for the product (Enhanced Ecommerce).", true,
                "ga:productRefunds")
        {
        }
    }
}