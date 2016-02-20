namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     Product adds divided by views of product details (Enhanced Ecommerce).
    /// </summary>
    public class CartToDetailRate : Metric<float>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="CartToDetailRate" />.
        /// </summary>
        public CartToDetailRate()
            : base(
                "Cart-to-Detail Rate", "Product adds divided by views of product details (Enhanced Ecommerce).", false,
                "ga:cartToDetailRate")
        {
        }
    }
}