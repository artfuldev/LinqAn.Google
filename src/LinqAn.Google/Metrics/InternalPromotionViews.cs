using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of views of an internal promotion (Enhanced Ecommerce).
	/// </summary>
	[Description("The number of views of an internal promotion (Enhanced Ecommerce).")]
	public class InternalPromotionViews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="InternalPromotionViews" />.
		/// </summary>
		public InternalPromotionViews(): base("Internal Promotion Views",true,"ga:internalPromotionViews")
		{
			
		}
	}
}

