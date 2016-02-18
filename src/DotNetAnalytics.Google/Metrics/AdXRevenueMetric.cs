namespace DotNetAnalytics.Google.Metrics
{
	public class AdXRevenueMetric: Metric<decimal>
	{
		public AdXRevenueMetric(): base("AdX Revenue","The total estimated revenue from AdX ads.",true,"ga:adxRevenue")
		{
			
		}
	}
}

