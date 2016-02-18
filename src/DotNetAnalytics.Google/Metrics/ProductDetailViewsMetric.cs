namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Number of times users viewed the product-detail page (Enhanced Ecommerce).
	/// </summary>
	public class ProductDetailViewsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductDetailViewsMetric" />.
		/// </summary>
		public ProductDetailViewsMetric(): base("Product Detail Views","Number of times users viewed the product-detail page (Enhanced Ecommerce).",true,"ga:productDetailViews")
		{
			
		}
	}
}

