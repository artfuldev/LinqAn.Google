namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Various stages of the shopping experience that users completed in a session, e.g., PRODUCT_VIEW, ADD_TO_CART,
    ///     CHECKOUT, etc. (Enhanced Ecommerce).
    /// </summary>
    public class ShoppingStageDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ShoppingStageDimension" />.
        /// </summary>
        public ShoppingStageDimension()
            : base(
                "Shopping Stage",
                "Various stages of the shopping experience that users completed in a session, e.g., PRODUCT_VIEW, ADD_TO_CART, CHECKOUT, etc. (Enhanced Ecommerce).",
                true, "ga:shoppingStage")
        {
        }
    }
}