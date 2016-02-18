namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	Unique purchases divided by views of product detail pages (Enhanced Ecommerce).
	/// </summary>
	public class BuyToDetailRateMetric: Metric<float>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="BuyToDetailRateMetric" />.
		/// </summary>
		public BuyToDetailRateMetric(): base("Buy-to-Detail Rate","Unique purchases divided by views of product detail pages (Enhanced Ecommerce).",false,"ga:buyToDetailRate")
		{
			
		}
	}
}

