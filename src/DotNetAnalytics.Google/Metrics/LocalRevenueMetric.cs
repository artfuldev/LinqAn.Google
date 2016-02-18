namespace DotNetAnalytics.Google.Metrics
{
	public class LocalRevenueMetric: Metric<decimal>
	{
		public LocalRevenueMetric(): base("Local Revenue","Transaction revenue in local currency.",false,"ga:localTransactionRevenue")
		{
			
		}
	}
}

