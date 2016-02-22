using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of ad impressions that were viewable. An impression is considered a viewable impression when it has appeared within a user's browser and had the opportunity to be seen.
	/// </summary>
	[Description("The percentage of ad impressions that were viewable. An impression is considered a viewable impression when it has appeared within a user's browser and had the opportunity to be seen.")]
	public class AdxViewableImpressionsPercent: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdxViewableImpressionsPercent" />.
		/// </summary>
		public AdxViewableImpressionsPercent(): base("AdX Viewable Impressions %",false,"ga:adxViewableImpressionsPercent")
		{
			
		}
	}
}

