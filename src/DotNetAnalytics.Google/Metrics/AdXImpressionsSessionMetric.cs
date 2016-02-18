namespace DotNetAnalytics.Google.Metrics
{
	public class AdXImpressionsSessionMetric: Metric<float>
	{
		public AdXImpressionsSessionMetric(): base("AdX Impressions / Session","The ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions).",false,"ga:adxImpressionsPerSession")
		{
			
		}
	}
}

