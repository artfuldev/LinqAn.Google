namespace DotNetAnalytics.Google.Metrics
{
	public class QuantityRefundedMetric: Metric<int>
	{
		/// <summary>
		/// 	Number of product units refunded (Enhanced Ecommerce).
		/// </summary>
		public QuantityRefundedMetric(): base("Quantity Refunded","Number of product units refunded (Enhanced Ecommerce).",true,"ga:quantityRefunded")
		{
			
		}
	}
}

