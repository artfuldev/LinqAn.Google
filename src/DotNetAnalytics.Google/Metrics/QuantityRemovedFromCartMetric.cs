namespace DotNetAnalytics.Google.Metrics
{
	public class QuantityRemovedFromCartMetric: Metric<int>
	{
		/// <summary>
		/// 	Number of product units removed from cart (Enhanced Ecommerce).
		/// </summary>
		public QuantityRemovedFromCartMetric(): base("Quantity Removed From Cart","Number of product units removed from cart (Enhanced Ecommerce).",true,"ga:quantityRemovedFromCart")
		{
			
		}
	}
}

