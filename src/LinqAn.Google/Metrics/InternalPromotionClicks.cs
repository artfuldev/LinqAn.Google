namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of clicks on an internal promotion (Enhanced Ecommerce).
	/// </summary>
	public class InternalPromotionClicks: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="InternalPromotionClicks" />.
		/// </summary>
		public InternalPromotionClicks(): base("Internal Promotion Clicks","The number of clicks on an internal promotion (Enhanced Ecommerce).",true,"ga:internalPromotionClicks")
		{
			
		}
	}
}

