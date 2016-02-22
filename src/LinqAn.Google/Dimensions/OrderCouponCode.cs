using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Code for the order-level coupon (Enhanced Ecommerce).
	/// </summary>
	[Description("Code for the order-level coupon (Enhanced Ecommerce).")]
	public class OrderCouponCode: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="OrderCouponCode" />.
		/// </summary>
		public OrderCouponCode(): base("Order Coupon Code",true,"ga:orderCouponCode")
		{
			
		}
	}
}

