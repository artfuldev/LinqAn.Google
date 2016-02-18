namespace DotNetAnalytics.Google.Metrics
{
	public class LocalProductRefundAmountMetric: Metric<decimal>
	{
		public LocalProductRefundAmountMetric(): base("Local Product Refund Amount","Refund amount for a given product in the local currency (Enhanced Ecommerce).",true,"ga:localProductRefundAmount")
		{
			
		}
	}
}

