namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The product sku for purchased items as you have defined them in your ecommerce tracking application.
    /// </summary>
    public class ProductSKU : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductSKU" />.
        /// </summary>
        public ProductSKU()
            : base(
                "Product SKU",
                "The product sku for purchased items as you have defined them in your ecommerce tracking application.",
                true, "ga:productSku")
        {
        }
    }
}