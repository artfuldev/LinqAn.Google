using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of clicks on an internal promotion (Enhanced Ecommerce).
	/// </summary>
	[Description("The number of clicks on an internal promotion (Enhanced Ecommerce).")]
	public class InternalPromotionClicks: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="InternalPromotionClicks" />.
		/// </summary>
		public InternalPromotionClicks(): base("Internal Promotion Clicks",true,"ga:internalPromotionClicks")
		{
			
		}
	}
}

