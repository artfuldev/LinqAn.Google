namespace DotNetAnalytics.Google.Metrics
{
	public class LocalShippingMetric: Metric<decimal>
	{
		public LocalShippingMetric(): base("Local Shipping","Transaction shipping cost in local currency.",false,"ga:localTransactionShipping")
		{
			
		}
	}
}

