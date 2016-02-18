namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The name of the product list in which the product appears (Enhanced Ecommerce).
    /// </summary>
    public class ProductListNameDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductListNameDimension" />.
        /// </summary>
        public ProductListNameDimension()
            : base(
                "Product List Name", "The name of the product list in which the product appears (Enhanced Ecommerce).",
                true, "ga:productListName")
        {
        }
    }
}