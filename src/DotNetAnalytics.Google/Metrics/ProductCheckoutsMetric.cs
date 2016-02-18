namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Number of times the product was included in the check-out process (Enhanced Ecommerce).
	/// </summary>
	public class ProductCheckoutsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductCheckoutsMetric" />.
		/// </summary>
		public ProductCheckoutsMetric(): base("Product Checkouts","Number of times the product was included in the check-out process (Enhanced Ecommerce).",true,"ga:productCheckouts")
		{
			
		}
	}
}

