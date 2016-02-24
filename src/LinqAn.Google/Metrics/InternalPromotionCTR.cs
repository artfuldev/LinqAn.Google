using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The rate at which users clicked through to view the internal promotion (ga:internalPromotionClicks / ga:internalPromotionViews) - (Enhanced Ecommerce).
	/// </summary>
	[Description("The rate at which users clicked through to view the internal promotion (ga:internalPromotionClicks / ga:internalPromotionViews) - (Enhanced Ecommerce).")]
	public class InternalPromotionCTR: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="InternalPromotionCTR" />.
		/// </summary>
		public InternalPromotionCTR(): base("Internal Promotion CTR",false,"ga:internalPromotionCTR")
		{
			
		}
	}
}

