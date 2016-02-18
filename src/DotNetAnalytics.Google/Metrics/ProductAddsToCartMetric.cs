namespace DotNetAnalytics.Google.Metrics
{
	public class ProductAddsToCartMetric: Metric<int>
	{
		/// <summary>
		/// 	Number of times the product was added to the shopping cart (Enhanced Ecommerce).
		/// </summary>
		public ProductAddsToCartMetric(): base("Product Adds To Cart","Number of times the product was added to the shopping cart (Enhanced Ecommerce).",true,"ga:productAddsToCart")
		{
			
		}
	}
}

