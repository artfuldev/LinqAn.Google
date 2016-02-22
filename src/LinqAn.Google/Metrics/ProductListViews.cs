using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of times the product appeared in a product list (Enhanced Ecommerce).
	/// </summary>
	[Description("Number of times the product appeared in a product list (Enhanced Ecommerce).")]
	public class ProductListViews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductListViews" />.
		/// </summary>
		public ProductListViews(): base("Product List Views",true,"ga:productListViews")
		{
			
		}
	}
}

