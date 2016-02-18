namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Number of product units added to the shopping cart (Enhanced Ecommerce).
    /// </summary>
    public class QuantityAddedToCartMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="QuantityAddedToCartMetric" />.
        /// </summary>
        public QuantityAddedToCartMetric()
            : base(
                "Quantity Added To Cart", "Number of product units added to the shopping cart (Enhanced Ecommerce).",
                true, "ga:quantityAddedToCart")
        {
        }
    }
}