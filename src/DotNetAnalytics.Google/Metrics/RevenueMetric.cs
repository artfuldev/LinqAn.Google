namespace DotNetAnalytics.Google.Metrics
{
	public class RevenueMetric: Metric<decimal>
	{
		public RevenueMetric(): base("Revenue","The total sale revenue provided in the transaction excluding shipping and tax.",true,"ga:transactionRevenue")
		{
			
		}
	}
}

