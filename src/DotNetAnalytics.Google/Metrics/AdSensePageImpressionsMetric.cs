namespace DotNetAnalytics.Google.Metrics
{
	public class AdSensePageImpressionsMetric: Metric<int>
	{
		public AdSensePageImpressionsMetric(): base("AdSense Page Impressions","The number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units.",true,"ga:adsensePageImpressions")
		{
			
		}
	}
}

