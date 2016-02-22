using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of times a refund was issued for the product (Enhanced Ecommerce).
	/// </summary>
	[Description("Number of times a refund was issued for the product (Enhanced Ecommerce).")]
	public class ProductRefunds: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductRefunds" />.
		/// </summary>
		public ProductRefunds(): base("Product Refunds",true,"ga:productRefunds")
		{
			
		}
	}
}

