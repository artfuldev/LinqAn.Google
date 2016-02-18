namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The number of clicks on an internal promotion (Enhanced Ecommerce).
	/// </summary>
	public class InternalPromotionClicksMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="InternalPromotionClicksMetric" />.
		/// </summary>
		public InternalPromotionClicksMetric(): base("Internal Promotion Clicks","The number of clicks on an internal promotion (Enhanced Ecommerce).",true,"ga:internalPromotionClicks")
		{
			
		}
	}
}

