namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total cost of shipping.
    /// </summary>
    public class Shipping : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Shipping" />.
        /// </summary>
        public Shipping() : base("Shipping", "The total cost of shipping.", true, "ga:transactionShipping")
        {
        }
    }
}