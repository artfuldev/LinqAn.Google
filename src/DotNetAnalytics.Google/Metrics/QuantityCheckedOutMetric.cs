namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Number of product units included in check out (Enhanced Ecommerce).
    /// </summary>
    public class QuantityCheckedOutMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="QuantityCheckedOutMetric" />.
        /// </summary>
        public QuantityCheckedOutMetric()
            : base(
                "Quantity Checked Out", "Number of product units included in check out (Enhanced Ecommerce).", true,
                "ga:quantityCheckedOut")
        {
        }
    }
}