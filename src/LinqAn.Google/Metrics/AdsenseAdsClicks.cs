namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times AdSense ads on your site were clicked.
	/// </summary>
	public class AdsenseAdsClicks: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdsenseAdsClicks" />.
		/// </summary>
		public AdsenseAdsClicks(): base("AdSense Ads Clicked","The number of times AdSense ads on your site were clicked.",true,"ga:adsenseAdsClicks")
		{
			
		}
	}
}

