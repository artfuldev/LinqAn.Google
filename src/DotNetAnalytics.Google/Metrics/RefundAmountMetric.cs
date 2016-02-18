namespace DotNetAnalytics.Google.Metrics
{
	public class RefundAmountMetric: Metric<decimal>
	{
		public RefundAmountMetric(): base("Refund Amount","Currency amount refunded for a transaction (Enhanced Ecommerce).",true,"ga:refundAmount")
		{
			
		}
	}
}

