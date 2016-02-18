namespace DotNetAnalytics.Google.Metrics
{
	public class ShippingMetric: Metric<decimal>
	{
		/// <summary>
		/// 	The total cost of shipping.
		/// </summary>
		public ShippingMetric(): base("Shipping","The total cost of shipping.",true,"ga:transactionShipping")
		{
			
		}
	}
}

