using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Total refund amount associated with the product (Enhanced Ecommerce).
	/// </summary>
	[Description("Total refund amount associated with the product (Enhanced Ecommerce).")]
	public class ProductRefundAmount: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductRefundAmount" />.
		/// </summary>
		public ProductRefundAmount(): base("Product Refund Amount",true,"ga:productRefundAmount")
		{
			
		}
	}
}

