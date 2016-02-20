namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Transaction shipping cost in local currency.
    /// </summary>
    public class LocalShipping : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LocalShipping" />.
        /// </summary>
        public LocalShipping()
            : base(
                "Local Shipping", "Transaction shipping cost in local currency.", false, "ga:localTransactionShipping")
        {
        }
    }
}