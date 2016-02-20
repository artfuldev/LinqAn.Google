namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The position of the product in the product list (Enhanced Ecommerce).
    /// </summary>
    public class ProductListPosition : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductListPosition" />.
        /// </summary>
        public ProductListPosition()
            : base(
                "Product List Position", "The position of the product in the product list (Enhanced Ecommerce).", true,
                "ga:productListPosition")
        {
        }
    }
}