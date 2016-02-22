using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Unique purchases divided by views of product detail pages (Enhanced Ecommerce).
	/// </summary>
	[Description("Unique purchases divided by views of product detail pages (Enhanced Ecommerce).")]
	public class BuyToDetailRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="BuyToDetailRate" />.
		/// </summary>
		public BuyToDetailRate(): base("Buy-to-Detail Rate",false,"ga:buyToDetailRate")
		{
			
		}
	}
}

