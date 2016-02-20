namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Total refund amount associated with the product (Enhanced Ecommerce).
    /// </summary>
    public class ProductRefundAmount : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductRefundAmount" />.
        /// </summary>
        public ProductRefundAmount()
            : base(
                "Product Refund Amount", "Total refund amount associated with the product (Enhanced Ecommerce).", true,
                "ga:productRefundAmount")
        {
        }
    }
}