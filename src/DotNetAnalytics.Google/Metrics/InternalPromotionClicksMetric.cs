namespace DotNetAnalytics.Google.Metrics
{
	public class InternalPromotionClicksMetric: Metric<int>
	{
		public InternalPromotionClicksMetric(): base("Internal Promotion Clicks","The number of clicks on an internal promotion (Enhanced Ecommerce).",true,"ga:internalPromotionClicks")
		{
			
		}
	}
}

