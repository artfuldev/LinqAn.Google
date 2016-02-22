using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total revenue from AdSense ads.
	/// </summary>
	[Description("The total revenue from AdSense ads.")]
	public class AdsenseRevenue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdsenseRevenue" />.
		/// </summary>
		public AdsenseRevenue(): base("AdSense Revenue",true,"ga:adsenseRevenue")
		{
			
		}
	}
}

