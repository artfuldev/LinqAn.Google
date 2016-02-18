namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Product revenue in local currency.
	/// </summary>
	public class LocalProductRevenueMetric: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="LocalProductRevenueMetric" />.
		/// </summary>
		public LocalProductRevenueMetric(): base("Local Product Revenue","Product revenue in local currency.",true,"ga:localItemRevenue")
		{
			
		}
	}
}

