using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Code for the product-level coupon (Enhanced Ecommerce).
	/// </summary>
	[Description("Code for the product-level coupon (Enhanced Ecommerce).")]
	public class ProductCouponCode: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductCouponCode" />.
		/// </summary>
		public ProductCouponCode(): base("Product Coupon Code",true,"ga:productCouponCode")
		{
			
		}
	}
}

