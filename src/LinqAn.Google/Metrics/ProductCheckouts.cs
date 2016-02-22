using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of times the product was included in the check-out process (Enhanced Ecommerce).
	/// </summary>
	[Description("Number of times the product was included in the check-out process (Enhanced Ecommerce).")]
	public class ProductCheckouts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductCheckouts" />.
		/// </summary>
		public ProductCheckouts(): base("Product Checkouts",true,"ga:productCheckouts")
		{
			
		}
	}
}

