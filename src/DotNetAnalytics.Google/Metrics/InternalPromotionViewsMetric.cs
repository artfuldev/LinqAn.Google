namespace DotNetAnalytics.Google.Metrics
{
	public class InternalPromotionViewsMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of views of an internal promotion (Enhanced Ecommerce).
		/// </summary>
		public InternalPromotionViewsMetric(): base("Internal Promotion Views","The number of views of an internal promotion (Enhanced Ecommerce).",true,"ga:internalPromotionViews")
		{
			
		}
	}
}

