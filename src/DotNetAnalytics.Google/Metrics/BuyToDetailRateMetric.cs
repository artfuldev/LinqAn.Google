namespace DotNetAnalytics.Google.Metrics
{
	public class BuyToDetailRateMetric: Metric<float>
	{
		/// <summary>
		/// 	Unique purchases divided by views of product detail pages (Enhanced Ecommerce).
		/// </summary>
		public BuyToDetailRateMetric(): base("Buy-to-Detail Rate","Unique purchases divided by views of product detail pages (Enhanced Ecommerce).",false,"ga:buyToDetailRate")
		{
			
		}
	}
}

