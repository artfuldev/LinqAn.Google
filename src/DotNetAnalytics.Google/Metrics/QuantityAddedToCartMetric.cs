namespace DotNetAnalytics.Google.Metrics
{
	public class QuantityAddedToCartMetric: Metric<int>
	{
		public QuantityAddedToCartMetric(): base("Quantity Added To Cart","Number of product units added to the shopping cart (Enhanced Ecommerce).",true,"ga:quantityAddedToCart")
		{
			
		}
	}
}

