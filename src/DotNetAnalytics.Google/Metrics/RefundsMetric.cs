namespace DotNetAnalytics.Google.Metrics
{
	public class RefundsMetric: Metric<int>
	{
		public RefundsMetric(): base("Refunds","Number of refunds that have been issued (Enhanced Ecommerce).",true,"ga:totalRefunds")
		{
			
		}
	}
}

