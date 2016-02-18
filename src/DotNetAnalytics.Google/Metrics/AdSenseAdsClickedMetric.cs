namespace DotNetAnalytics.Google.Metrics
{
	public class AdSenseAdsClickedMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of times AdSense ads on your site were clicked.
		/// </summary>
		public AdSenseAdsClickedMetric(): base("AdSense Ads Clicked","The number of times AdSense ads on your site were clicked.",true,"ga:adsenseAdsClicks")
		{
			
		}
	}
}

