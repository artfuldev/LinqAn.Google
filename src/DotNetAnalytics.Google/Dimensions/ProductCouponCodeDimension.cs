namespace DotNetAnalytics.Google.Dimensions
{
	public class ProductCouponCodeDimension: Dimension<string>
	{
		/// <summary>
		/// 	Code for the product-level coupon (Enhanced Ecommerce).
		/// </summary>
		public ProductCouponCodeDimension(): base("Product Coupon Code","Code for the product-level coupon (Enhanced Ecommerce).",true,"ga:productCouponCode")
		{
			
		}
	}
}

