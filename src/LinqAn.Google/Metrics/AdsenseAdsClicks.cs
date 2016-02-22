using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times AdSense ads on your site were clicked.
	/// </summary>
	[Description("The number of times AdSense ads on your site were clicked.")]
	public class AdsenseAdsClicks: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdsenseAdsClicks" />.
		/// </summary>
		public AdsenseAdsClicks(): base("AdSense Ads Clicked",true,"ga:adsenseAdsClicks")
		{
			
		}
	}
}

