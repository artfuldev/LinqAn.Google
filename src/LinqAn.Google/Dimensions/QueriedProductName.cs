namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     Name of the product being queried.
    /// </summary>
    public class QueriedProductName : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="QueriedProductName" />.
        /// </summary>
        public QueriedProductName()
            : base("Queried Product Name", "Name of the product being queried.", false, "ga:queryProductName")
        {
        }
    }
}