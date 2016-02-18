namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     Transaction shipping cost in local currency.
    /// </summary>
    public class LocalShippingMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LocalShippingMetric" />.
        /// </summary>
        public LocalShippingMetric()
            : base(
                "Local Shipping", "Transaction shipping cost in local currency.", false, "ga:localTransactionShipping")
        {
        }
    }
}