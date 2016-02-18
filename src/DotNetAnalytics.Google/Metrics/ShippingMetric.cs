namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total cost of shipping.
    /// </summary>
    public class ShippingMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ShippingMetric" />.
        /// </summary>
        public ShippingMetric() : base("Shipping", "The total cost of shipping.", true, "ga:transactionShipping")
        {
        }
    }
}