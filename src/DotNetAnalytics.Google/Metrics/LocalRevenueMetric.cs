namespace DotNetAnalytics.Google.Metrics
{
	public class LocalRevenueMetric: Metric<decimal>
	{
		/// <summary>
		/// 	Transaction revenue in local currency.
		/// </summary>
		public LocalRevenueMetric(): base("Local Revenue","Transaction revenue in local currency.",false,"ga:localTransactionRevenue")
		{
			
		}
	}
}

