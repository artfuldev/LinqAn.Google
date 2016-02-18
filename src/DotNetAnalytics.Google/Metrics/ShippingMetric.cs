namespace DotNetAnalytics.Google.Metrics
{
	public class ShippingMetric: Metric<decimal>
	{
		public ShippingMetric(): base("Shipping","The total cost of shipping.",true,"ga:transactionShipping")
		{
			
		}
	}
}

