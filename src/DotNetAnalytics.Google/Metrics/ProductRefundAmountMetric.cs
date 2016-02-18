namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Total refund amount associated with the product (Enhanced Ecommerce).
	/// </summary>
	public class ProductRefundAmountMetric: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductRefundAmountMetric" />.
		/// </summary>
		public ProductRefundAmountMetric(): base("Product Refund Amount","Total refund amount associated with the product (Enhanced Ecommerce).",true,"ga:productRefundAmount")
		{
			
		}
	}
}

