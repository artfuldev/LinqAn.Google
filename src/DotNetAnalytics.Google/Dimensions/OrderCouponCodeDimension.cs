namespace DotNetAnalytics.Google.Dimensions
{
	public class OrderCouponCodeDimension: Dimension<string>
	{
		/// <summary>
		/// 	Code for the order-level coupon (Enhanced Ecommerce).
		/// </summary>
		public OrderCouponCodeDimension(): base("Order Coupon Code","Code for the order-level coupon (Enhanced Ecommerce).",true,"ga:orderCouponCode")
		{
			
		}
	}
}

