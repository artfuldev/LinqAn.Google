namespace DotNetAnalytics.Google.Metrics
{
	public class LocalProductRevenueMetric: Metric<decimal>
	{
		public LocalProductRevenueMetric(): base("Local Product Revenue","Product revenue in local currency.",true,"ga:localItemRevenue")
		{
			
		}
	}
}

