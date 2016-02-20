namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Quantity of the product being queried.
    /// </summary>
    public class QueriedProductQuantity : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="QueriedProductQuantity" />.
        /// </summary>
        public QueriedProductQuantity()
            : base(
                "Queried Product Quantity", "Quantity of the product being queried.", false, "ga:queryProductQuantity")
        {
        }
    }
}