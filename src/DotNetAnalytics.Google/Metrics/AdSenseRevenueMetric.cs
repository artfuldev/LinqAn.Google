namespace DotNetAnalytics.Google.Metrics
{
	public class AdSenseRevenueMetric: Metric<decimal>
	{
		/// <summary>
		/// 	The total revenue from AdSense ads.
		/// </summary>
		public AdSenseRevenueMetric(): base("AdSense Revenue","The total revenue from AdSense ads.",true,"ga:adsenseRevenue")
		{
			
		}
	}
}

