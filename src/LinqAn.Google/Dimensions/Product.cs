namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The product name for purchased items as supplied by your ecommerce tracking application.
    /// </summary>
    public class Product : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="Product" />.
        /// </summary>
        public Product()
            : base(
                "Product", "The product name for purchased items as supplied by your ecommerce tracking application.",
                true, "ga:productName")
        {
        }
    }
}