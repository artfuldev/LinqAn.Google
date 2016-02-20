namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The name of the product list in which the product appears (Enhanced Ecommerce).
    /// </summary>
    public class ProductListName : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductListName" />.
        /// </summary>
        public ProductListName()
            : base(
                "Product List Name", "The name of the product list in which the product appears (Enhanced Ecommerce).",
                true, "ga:productListName")
        {
        }
    }
}