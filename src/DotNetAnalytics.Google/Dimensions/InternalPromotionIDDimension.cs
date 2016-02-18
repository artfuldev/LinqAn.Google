namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The ID of the promotion (Enhanced Ecommerce).
	/// </summary>
	public class InternalPromotionIDDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="InternalPromotionIDDimension" />.
		/// </summary>
		public InternalPromotionIDDimension(): base("Internal Promotion ID","The ID of the promotion (Enhanced Ecommerce).",true,"ga:internalPromotionId")
		{
			
		}
	}
}

