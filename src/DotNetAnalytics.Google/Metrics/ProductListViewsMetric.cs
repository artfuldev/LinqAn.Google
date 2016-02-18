namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Number of times the product appeared in a product list (Enhanced Ecommerce).
	/// </summary>
	public class ProductListViewsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductListViewsMetric" />.
		/// </summary>
		public ProductListViewsMetric(): base("Product List Views","Number of times the product appeared in a product list (Enhanced Ecommerce).",true,"ga:productListViews")
		{
			
		}
	}
}

