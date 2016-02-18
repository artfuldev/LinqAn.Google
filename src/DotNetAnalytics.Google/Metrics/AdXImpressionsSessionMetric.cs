namespace DotNetAnalytics.Google.Metrics
{
	public class AdXImpressionsSessionMetric: Metric<float>
	{
		/// <summary>
		/// 	The ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions).
		/// </summary>
		public AdXImpressionsSessionMetric(): base("AdX Impressions / Session","The ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions).",false,"ga:adxImpressionsPerSession")
		{
			
		}
	}
}

