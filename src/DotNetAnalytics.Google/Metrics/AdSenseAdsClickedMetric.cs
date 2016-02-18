namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The number of times AdSense ads on your site were clicked.
	/// </summary>
	public class AdSenseAdsClickedMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdSenseAdsClickedMetric" />.
		/// </summary>
		public AdSenseAdsClickedMetric(): base("AdSense Ads Clicked","The number of times AdSense ads on your site were clicked.",true,"ga:adsenseAdsClicks")
		{
			
		}
	}
}

