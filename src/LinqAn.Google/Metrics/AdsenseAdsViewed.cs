using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit.
	/// </summary>
	[Description("The number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit.")]
	public class AdsenseAdsViewed: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdsenseAdsViewed" />.
		/// </summary>
		public AdsenseAdsViewed(): base("AdSense Impressions",true,"ga:adsenseAdsViewed")
		{
			
		}
	}
}

