namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The number of views of an internal promotion (Enhanced Ecommerce).
	/// </summary>
	public class InternalPromotionViewsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="InternalPromotionViewsMetric" />.
		/// </summary>
		public InternalPromotionViewsMetric(): base("Internal Promotion Views","The number of views of an internal promotion (Enhanced Ecommerce).",true,"ga:internalPromotionViews")
		{
			
		}
	}
}

