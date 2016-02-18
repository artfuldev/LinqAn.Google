namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Number of times users clicked the product when it appeared in the product list (Enhanced Ecommerce).
    /// </summary>
    public class ProductListClicksMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductListClicksMetric" />.
        /// </summary>
        public ProductListClicksMetric()
            : base(
                "Product List Clicks",
                "Number of times users clicked the product when it appeared in the product list (Enhanced Ecommerce).",
                true, "ga:productListClicks")
        {
        }
    }
}