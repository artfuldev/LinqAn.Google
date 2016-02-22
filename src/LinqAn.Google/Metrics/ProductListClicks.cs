using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of times users clicked the product when it appeared in the product list (Enhanced Ecommerce).
	/// </summary>
	[Description("Number of times users clicked the product when it appeared in the product list (Enhanced Ecommerce).")]
	public class ProductListClicks: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductListClicks" />.
		/// </summary>
		public ProductListClicks(): base("Product List Clicks",true,"ga:productListClicks")
		{
			
		}
	}
}

