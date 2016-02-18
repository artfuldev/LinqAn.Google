namespace DotNetAnalytics.Google.Metrics
{
	public class CartToDetailRateMetric: Metric<float>
	{
		public CartToDetailRateMetric(): base("Cart-to-Detail Rate","Product adds divided by views of product details (Enhanced Ecommerce).",false,"ga:cartToDetailRate")
		{
			
		}
	}
}

