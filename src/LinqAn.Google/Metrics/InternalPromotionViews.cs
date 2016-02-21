namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of views of an internal promotion (Enhanced Ecommerce).
	/// </summary>
	public class InternalPromotionViews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="InternalPromotionViews" />.
		/// </summary>
		public InternalPromotionViews(): base("Internal Promotion Views","The number of views of an internal promotion (Enhanced Ecommerce).",true,"ga:internalPromotionViews")
		{
			
		}
	}
}

