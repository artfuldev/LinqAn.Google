namespace DotNetAnalytics.Google.Metrics
{
	public class AdSenseViewableImpressionMetric: Metric<float>
	{
		/// <summary>
		/// 	The percentage of impressions that were viewable.
		/// </summary>
		public AdSenseViewableImpressionMetric(): base("AdSense Viewable Impression %","The percentage of impressions that were viewable.",false,"ga:adsenseViewableImpressionPercent")
		{
			
		}
	}
}

