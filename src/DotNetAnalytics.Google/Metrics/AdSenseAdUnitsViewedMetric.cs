namespace DotNetAnalytics.Google.Metrics
{
	public class AdSenseAdUnitsViewedMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of AdSense ad units viewed. An Ad unit is a set of ads displayed as a result of one piece of the AdSense ad code. Details: https://support.google.com/adsense/answer/32715?hl=en
		/// </summary>
		public AdSenseAdUnitsViewedMetric(): base("AdSense Ad Units Viewed","The number of AdSense ad units viewed. An Ad unit is a set of ads displayed as a result of one piece of the AdSense ad code. Details: https://support.google.com/adsense/answer/32715?hl=en",true,"ga:adsenseAdUnitsViewed")
		{
			
		}
	}
}

