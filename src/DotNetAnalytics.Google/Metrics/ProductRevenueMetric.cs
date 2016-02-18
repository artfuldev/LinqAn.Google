namespace DotNetAnalytics.Google.Metrics
{
	public class ProductRevenueMetric: Metric<decimal>
	{
		/// <summary>
		/// 	The total revenue from purchased product items.
		/// </summary>
		public ProductRevenueMetric(): base("Product Revenue","The total revenue from purchased product items.",true,"ga:itemRevenue")
		{
			
		}
	}
}

