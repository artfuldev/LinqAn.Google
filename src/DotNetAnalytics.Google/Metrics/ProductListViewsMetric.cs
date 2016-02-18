namespace DotNetAnalytics.Google.Metrics
{
	public class ProductListViewsMetric: Metric<int>
	{
		public ProductListViewsMetric(): base("Product List Views","Number of times the product appeared in a product list (Enhanced Ecommerce).",true,"ga:productListViews")
		{
			
		}
	}
}

