namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Number of times the product was removed from shopping cart (Enhanced Ecommerce).
    /// </summary>
    public class ProductRemovesFromCart : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductRemovesFromCart" />.
        /// </summary>
        public ProductRemovesFromCart()
            : base(
                "Product Removes From Cart",
                "Number of times the product was removed from shopping cart (Enhanced Ecommerce).", true,
                "ga:productRemovesFromCart")
        {
        }
    }
}