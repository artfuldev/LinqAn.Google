namespace DotNetAnalytics.Google.Metrics
{
	public class AdSenseViewableImpressionMetric: Metric<float>
	{
		public AdSenseViewableImpressionMetric(): base("AdSense Viewable Impression %","The percentage of impressions that were viewable.",false,"ga:adsenseViewableImpressionPercent")
		{
			
		}
	}
}

