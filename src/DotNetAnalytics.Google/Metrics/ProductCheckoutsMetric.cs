namespace DotNetAnalytics.Google.Metrics
{
	public class ProductCheckoutsMetric: Metric<int>
	{
		/// <summary>
		/// 	Number of times the product was included in the check-out process (Enhanced Ecommerce).
		/// </summary>
		public ProductCheckoutsMetric(): base("Product Checkouts","Number of times the product was included in the check-out process (Enhanced Ecommerce).",true,"ga:productCheckouts")
		{
			
		}
	}
}

