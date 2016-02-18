namespace DotNetAnalytics.Google.Metrics
{
	public class InternalPromotionViewsMetric: Metric<int>
	{
		public InternalPromotionViewsMetric(): base("Internal Promotion Views","The number of views of an internal promotion (Enhanced Ecommerce).",true,"ga:internalPromotionViews")
		{
			
		}
	}
}

