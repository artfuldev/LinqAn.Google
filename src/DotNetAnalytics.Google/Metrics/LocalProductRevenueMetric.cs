namespace DotNetAnalytics.Google.Metrics
{
	public class LocalProductRevenueMetric: Metric<decimal>
	{
		/// <summary>
		/// 	Product revenue in local currency.
		/// </summary>
		public LocalProductRevenueMetric(): base("Local Product Revenue","Product revenue in local currency.",true,"ga:localItemRevenue")
		{
			
		}
	}
}

