namespace DotNetAnalytics.Google.Metrics
{
	public class ProductRevenueMetric: Metric<decimal>
	{
		public ProductRevenueMetric(): base("Product Revenue","The total revenue from purchased product items.",true,"ga:itemRevenue")
		{
			
		}
	}
}

