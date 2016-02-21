namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Unique purchases divided by views of product detail pages (Enhanced Ecommerce).
	/// </summary>
	public class BuyToDetailRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="BuyToDetailRate" />.
		/// </summary>
		public BuyToDetailRate(): base("Buy-to-Detail Rate","Unique purchases divided by views of product detail pages (Enhanced Ecommerce).",false,"ga:buyToDetailRate")
		{
			
		}
	}
}

