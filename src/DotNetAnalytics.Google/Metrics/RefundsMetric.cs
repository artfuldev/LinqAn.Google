namespace DotNetAnalytics.Google.Metrics
{
	public class RefundsMetric: Metric<int>
	{
		/// <summary>
		/// 	Number of refunds that have been issued (Enhanced Ecommerce).
		/// </summary>
		public RefundsMetric(): base("Refunds","Number of refunds that have been issued (Enhanced Ecommerce).",true,"ga:totalRefunds")
		{
			
		}
	}
}

