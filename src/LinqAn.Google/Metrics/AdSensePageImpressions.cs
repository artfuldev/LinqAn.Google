using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units.
	/// </summary>
	[Description("The number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units.")]
	public class AdsensePageImpressions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdsensePageImpressions" />.
		/// </summary>
		public AdsensePageImpressions(): base("AdSense Page Impressions",true,"ga:adsensePageImpressions")
		{
			
		}
	}
}

