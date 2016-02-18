namespace DotNetAnalytics.Google.Metrics
{
	public class InternalPromotionClicksMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of clicks on an internal promotion (Enhanced Ecommerce).
		/// </summary>
		public InternalPromotionClicksMetric(): base("Internal Promotion Clicks","The number of clicks on an internal promotion (Enhanced Ecommerce).",true,"ga:internalPromotionClicks")
		{
			
		}
	}
}

