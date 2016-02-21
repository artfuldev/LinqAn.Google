namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit.
	/// </summary>
	public class AdsenseAdsViewed: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdsenseAdsViewed" />.
		/// </summary>
		public AdsenseAdsViewed(): base("AdSense Impressions","The number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit.",true,"ga:adsenseAdsViewed")
		{
			
		}
	}
}

