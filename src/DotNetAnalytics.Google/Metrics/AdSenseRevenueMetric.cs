namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total revenue from AdSense ads.
	/// </summary>
	public class AdSenseRevenueMetric: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdSenseRevenueMetric" />.
		/// </summary>
		public AdSenseRevenueMetric(): base("AdSense Revenue","The total revenue from AdSense ads.",true,"ga:adsenseRevenue")
		{
			
		}
	}
}

