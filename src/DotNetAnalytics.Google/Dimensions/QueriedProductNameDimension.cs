namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Name of the product being queried.
    /// </summary>
    public class QueriedProductNameDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="QueriedProductNameDimension" />.
        /// </summary>
        public QueriedProductNameDimension()
            : base("Queried Product Name", "Name of the product being queried.", false, "ga:queryProductName")
        {
        }
    }
}