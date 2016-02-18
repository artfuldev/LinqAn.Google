namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Product adds divided by views of product details (Enhanced Ecommerce).
    /// </summary>
    public class CartToDetailRateMetric : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="CartToDetailRateMetric" />.
        /// </summary>
        public CartToDetailRateMetric()
            : base(
                "Cart-to-Detail Rate", "Product adds divided by views of product details (Enhanced Ecommerce).", false,
                "ga:cartToDetailRate")
        {
        }
    }
}