namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     Code for the order-level coupon (Enhanced Ecommerce).
    /// </summary>
    public class OrderCouponCodeDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="OrderCouponCodeDimension" />.
        /// </summary>
        public OrderCouponCodeDimension()
            : base(
                "Order Coupon Code", "Code for the order-level coupon (Enhanced Ecommerce).", true, "ga:orderCouponCode"
                )
        {
        }
    }
}