namespace DotNetAnalytics.Google.Metrics
{
	public class ProductRefundsMetric: Metric<int>
	{
		public ProductRefundsMetric(): base("Product Refunds","Number of times a refund was issued for the product (Enhanced Ecommerce).",true,"ga:productRefunds")
		{
			
		}
	}
}

