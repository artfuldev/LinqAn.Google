namespace DotNetAnalytics.Google.Metrics
{
	public class LocalRefundAmountMetric: Metric<decimal>
	{
		public LocalRefundAmountMetric(): base("Local Refund Amount","Total refund amount for the transaction in the local currency (Enhanced Ecommerce).",true,"ga:localRefundAmount")
		{
			
		}
	}
}

