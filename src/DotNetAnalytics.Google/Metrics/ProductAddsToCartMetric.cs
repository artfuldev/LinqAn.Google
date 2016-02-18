namespace DotNetAnalytics.Google.Metrics
{
	public class ProductAddsToCartMetric: Metric<int>
	{
		public ProductAddsToCartMetric(): base("Product Adds To Cart","Number of times the product was added to the shopping cart (Enhanced Ecommerce).",true,"ga:productAddsToCart")
		{
			
		}
	}
}

