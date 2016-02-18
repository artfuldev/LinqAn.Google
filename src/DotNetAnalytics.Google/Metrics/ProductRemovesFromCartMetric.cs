namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Number of times the product was removed from shopping cart (Enhanced Ecommerce).
	/// </summary>
	public class ProductRemovesFromCartMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductRemovesFromCartMetric" />.
		/// </summary>
		public ProductRemovesFromCartMetric(): base("Product Removes From Cart","Number of times the product was removed from shopping cart (Enhanced Ecommerce).",true,"ga:productRemovesFromCart")
		{
			
		}
	}
}

