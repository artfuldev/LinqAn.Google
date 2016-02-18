namespace DotNetAnalytics.Google.Metrics
{
	public class ProductDetailViewsMetric: Metric<int>
	{
		/// <summary>
		/// 	Number of times users viewed the product-detail page (Enhanced Ecommerce).
		/// </summary>
		public ProductDetailViewsMetric(): base("Product Detail Views","Number of times users viewed the product-detail page (Enhanced Ecommerce).",true,"ga:productDetailViews")
		{
			
		}
	}
}

