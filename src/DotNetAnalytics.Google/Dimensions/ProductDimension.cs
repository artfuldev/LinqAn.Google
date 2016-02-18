namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The product name for purchased items as supplied by your ecommerce tracking application.
    /// </summary>
    public class ProductDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductDimension" />.
        /// </summary>
        public ProductDimension()
            : base(
                "Product", "The product name for purchased items as supplied by your ecommerce tracking application.",
                true, "ga:productName")
        {
        }
    }
}