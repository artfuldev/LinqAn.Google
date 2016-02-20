namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total revenue from purchased product items.
    /// </summary>
    public class ProductRevenue : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductRevenue" />.
        /// </summary>
        public ProductRevenue()
            : base("Product Revenue", "The total revenue from purchased product items.", true, "ga:itemRevenue")
        {
        }
    }
}