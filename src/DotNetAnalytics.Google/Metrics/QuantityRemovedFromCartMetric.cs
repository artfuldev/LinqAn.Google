namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Number of product units removed from cart (Enhanced Ecommerce).
	/// </summary>
	public class QuantityRemovedFromCartMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="QuantityRemovedFromCartMetric" />.
		/// </summary>
		public QuantityRemovedFromCartMetric(): base("Quantity Removed From Cart","Number of product units removed from cart (Enhanced Ecommerce).",true,"ga:quantityRemovedFromCart")
		{
			
		}
	}
}

