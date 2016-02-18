namespace DotNetAnalytics.Google.Metrics
{
	public class QuantityRemovedFromCartMetric: Metric<int>
	{
		public QuantityRemovedFromCartMetric(): base("Quantity Removed From Cart","Number of product units removed from cart (Enhanced Ecommerce).",true,"ga:quantityRemovedFromCart")
		{
			
		}
	}
}

