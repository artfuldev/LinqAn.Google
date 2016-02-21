namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions).
	/// </summary>
	public class AdxImpressionsPerSession: Metric<float>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdxImpressionsPerSession" />.
		/// </summary>
		public AdxImpressionsPerSession(): base("AdX Impressions / Session","The ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions).",false,"ga:adxImpressionsPerSession")
		{
			
		}
	}
}

