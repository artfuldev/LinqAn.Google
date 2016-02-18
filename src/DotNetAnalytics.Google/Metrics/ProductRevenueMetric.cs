namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total revenue from purchased product items.
    /// </summary>
    public class ProductRevenueMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductRevenueMetric" />.
        /// </summary>
        public ProductRevenueMetric()
            : base("Product Revenue", "The total revenue from purchased product items.", true, "ga:itemRevenue")
        {
        }
    }
}