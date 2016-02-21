namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of impressions that were viewable.
	/// </summary>
	public class AdsenseViewableImpressionPercent: Metric<float>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdsenseViewableImpressionPercent" />.
		/// </summary>
		public AdsenseViewableImpressionPercent(): base("AdSense Viewable Impression %","The percentage of impressions that were viewable.",false,"ga:adsenseViewableImpressionPercent")
		{
			
		}
	}
}

