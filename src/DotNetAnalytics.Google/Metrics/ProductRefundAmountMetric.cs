namespace DotNetAnalytics.Google.Metrics
{
	public class ProductRefundAmountMetric: Metric<decimal>
	{
		public ProductRefundAmountMetric(): base("Product Refund Amount","Total refund amount associated with the product (Enhanced Ecommerce).",true,"ga:productRefundAmount")
		{
			
		}
	}
}

