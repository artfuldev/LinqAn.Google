namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Code for the product-level coupon (Enhanced Ecommerce).
    /// </summary>
    public class ProductCouponCodeDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ProductCouponCodeDimension" />.
        /// </summary>
        public ProductCouponCodeDimension()
            : base(
                "Product Coupon Code", "Code for the product-level coupon (Enhanced Ecommerce).", true,
                "ga:productCouponCode")
        {
        }
    }
}