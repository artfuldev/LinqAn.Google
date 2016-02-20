namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total sale revenue provided in the transaction excluding shipping and tax.
    /// </summary>
    public class Revenue : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Revenue" />.
        /// </summary>
        public Revenue()
            : base(
                "Revenue", "The total sale revenue provided in the transaction excluding shipping and tax.", true,
                "ga:transactionRevenue")
        {
        }
    }
}