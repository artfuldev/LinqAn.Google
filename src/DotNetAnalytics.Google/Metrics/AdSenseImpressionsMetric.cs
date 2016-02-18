namespace DotNetAnalytics.Google.Metrics
{
	public class AdSenseImpressionsMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit.
		/// </summary>
		public AdSenseImpressionsMetric(): base("AdSense Impressions","The number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit.",true,"ga:adsenseAdsViewed")
		{
			
		}
	}
}

