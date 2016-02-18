namespace DotNetAnalytics.Google.Metrics
{
	public class ProductRefundAmountMetric: Metric<decimal>
	{
		/// <summary>
		/// 	Total refund amount associated with the product (Enhanced Ecommerce).
		/// </summary>
		public ProductRefundAmountMetric(): base("Product Refund Amount","Total refund amount associated with the product (Enhanced Ecommerce).",true,"ga:productRefundAmount")
		{
			
		}
	}
}

