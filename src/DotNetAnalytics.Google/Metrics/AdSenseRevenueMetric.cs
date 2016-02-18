namespace DotNetAnalytics.Google.Metrics
{
	public class AdSenseRevenueMetric: Metric<decimal>
	{
		public AdSenseRevenueMetric(): base("AdSense Revenue","The total revenue from AdSense ads.",true,"ga:adsenseRevenue")
		{
			
		}
	}
}

