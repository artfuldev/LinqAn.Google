namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions).
	/// </summary>
	public class AdXImpressionsSessionMetric: Metric<float>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdXImpressionsSessionMetric" />.
		/// </summary>
		public AdXImpressionsSessionMetric(): base("AdX Impressions / Session","The ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions).",false,"ga:adxImpressionsPerSession")
		{
			
		}
	}
}

