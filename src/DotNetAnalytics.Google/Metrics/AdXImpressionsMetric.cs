namespace DotNetAnalytics.Google.Metrics
{
	public class AdXImpressionsMetric: Metric<int>
	{
		public AdXImpressionsMetric(): base("AdX Impressions","An AdX ad impression is reported whenever an individual ad is displayed on your website. For example, if a page with two ad units is viewed once, we'll display two impressions.",true,"ga:adxImpressions")
		{
			
		}
	}
}

