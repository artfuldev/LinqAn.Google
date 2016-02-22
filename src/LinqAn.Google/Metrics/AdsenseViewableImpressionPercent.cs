using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of impressions that were viewable.
	/// </summary>
	[Description("The percentage of impressions that were viewable.")]
	public class AdsenseViewableImpressionPercent: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdsenseViewableImpressionPercent" />.
		/// </summary>
		public AdsenseViewableImpressionPercent(): base("AdSense Viewable Impression %",false,"ga:adsenseViewableImpressionPercent")
		{
			
		}
	}
}

