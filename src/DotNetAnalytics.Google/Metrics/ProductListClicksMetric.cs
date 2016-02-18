namespace DotNetAnalytics.Google.Metrics
{
	public class ProductListClicksMetric: Metric<int>
	{
		public ProductListClicksMetric(): base("Product List Clicks","Number of times users clicked the product when it appeared in the product list (Enhanced Ecommerce).",true,"ga:productListClicks")
		{
			
		}
	}
}

