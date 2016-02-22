using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Number of times users viewed the product-detail page (Enhanced Ecommerce).
	/// </summary>
	[Description("Number of times users viewed the product-detail page (Enhanced Ecommerce).")]
	public class ProductDetailViews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ProductDetailViews" />.
		/// </summary>
		public ProductDetailViews(): base("Product Detail Views",true,"ga:productDetailViews")
		{
			
		}
	}
}

