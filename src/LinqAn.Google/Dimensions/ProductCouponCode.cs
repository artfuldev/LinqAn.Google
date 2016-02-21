namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Code for the product-level coupon (Enhanced Ecommerce).
	/// </summary>
	public class ProductCouponCode: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductCouponCode" />.
		/// </summary>
		public ProductCouponCode(): base("Product Coupon Code","Code for the product-level coupon (Enhanced Ecommerce).",true,"ga:productCouponCode")
		{
			
		}
	}
}

