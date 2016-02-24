using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Average product revenue per purchase (commonly used with Product Coupon Code) (ga:itemRevenue / ga:uniquePurchases) - (Enhanced Ecommerce).
	/// </summary>
	[Description("Average product revenue per purchase (commonly used with Product Coupon Code) (ga:itemRevenue / ga:uniquePurchases) - (Enhanced Ecommerce).")]
	public class ProductRevenuePerPurchase: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductRevenuePerPurchase" />.
		/// </summary>
		public ProductRevenuePerPurchase(): base("Product Revenue per Purchase",false,"ga:productRevenuePerPurchase")
		{
			
		}
	}
}

