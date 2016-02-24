using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which users clicked through on the product in a product list (ga:productListClicks / ga:productListViews) - (Enhanced Ecommerce).
	/// </summary>
	[Description("The rate at which users clicked through on the product in a product list (ga:productListClicks / ga:productListViews) - (Enhanced Ecommerce).")]
	public class ProductListCTR: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductListCTR" />.
		/// </summary>
		public ProductListCTR(): base("Product List CTR",false,"ga:productListCTR")
		{
			
		}
	}
}

