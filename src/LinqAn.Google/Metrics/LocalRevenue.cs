namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Transaction revenue in local currency.
    /// </summary>
    public class LocalRevenue : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LocalRevenue" />.
        /// </summary>
        public LocalRevenue()
            : base("Local Revenue", "Transaction revenue in local currency.", false, "ga:localTransactionRevenue")
        {
        }
    }
}