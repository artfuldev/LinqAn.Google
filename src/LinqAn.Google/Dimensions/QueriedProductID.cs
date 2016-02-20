namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     ID of the product being queried.
    /// </summary>
    public class QueriedProductID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="QueriedProductID" />.
        /// </summary>
        public QueriedProductID()
            : base("Queried Product ID", "ID of the product being queried.", false, "ga:queryProductId")
        {
        }
    }
}