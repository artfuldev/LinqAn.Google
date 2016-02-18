namespace DotNetAnalytics.Google.Metrics
{
	public class ProductRemovesFromCartMetric: Metric<int>
	{
		public ProductRemovesFromCartMetric(): base("Product Removes From Cart","Number of times the product was removed from shopping cart (Enhanced Ecommerce).",true,"ga:productRemovesFromCart")
		{
			
		}
	}
}

