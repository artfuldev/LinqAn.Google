using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions).
	/// </summary>
	[Description("The ratio of AdX ad impressions to Analytics sessions (Ad Impressions / Analytics Sessions).")]
	public class AdxImpressionsPerSession: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdxImpressionsPerSession" />.
		/// </summary>
		public AdxImpressionsPerSession(): base("AdX Impressions / Session",false,"ga:adxImpressionsPerSession")
		{
			
		}
	}
}

