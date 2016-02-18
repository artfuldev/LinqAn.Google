namespace DotNetAnalytics.Google.Metrics
{
	public class RevenueMetric: Metric<decimal>
	{
		/// <summary>
		/// 	The total sale revenue provided in the transaction excluding shipping and tax.
		/// </summary>
		public RevenueMetric(): base("Revenue","The total sale revenue provided in the transaction excluding shipping and tax.",true,"ga:transactionRevenue")
		{
			
		}
	}
}

