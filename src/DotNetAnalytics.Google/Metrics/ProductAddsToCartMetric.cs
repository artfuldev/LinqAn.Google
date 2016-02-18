namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Number of times the product was added to the shopping cart (Enhanced Ecommerce).
	/// </summary>
	public class ProductAddsToCartMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ProductAddsToCartMetric" />.
		/// </summary>
		public ProductAddsToCartMetric(): base("Product Adds To Cart","Number of times the product was added to the shopping cart (Enhanced Ecommerce).",true,"ga:productAddsToCart")
		{
			
		}
	}
}

