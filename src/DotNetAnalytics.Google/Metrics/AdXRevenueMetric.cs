namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total estimated revenue from AdX ads.
	/// </summary>
	public class AdXRevenueMetric: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdXRevenueMetric" />.
		/// </summary>
		public AdXRevenueMetric(): base("AdX Revenue","The total estimated revenue from AdX ads.",true,"ga:adxRevenue")
		{
			
		}
	}
}

