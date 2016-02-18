namespace DotNetAnalytics.Google.Metrics
{
	public class QuantityRefundedMetric: Metric<int>
	{
		public QuantityRefundedMetric(): base("Quantity Refunded","Number of product units refunded (Enhanced Ecommerce).",true,"ga:quantityRefunded")
		{
			
		}
	}
}

