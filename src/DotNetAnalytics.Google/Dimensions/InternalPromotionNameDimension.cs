namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The name of the promotion (Enhanced Ecommerce).
	/// </summary>
	public class InternalPromotionNameDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="InternalPromotionNameDimension" />.
		/// </summary>
		public InternalPromotionNameDimension(): base("Internal Promotion Name","The name of the promotion (Enhanced Ecommerce).",true,"ga:internalPromotionName")
		{
			
		}
	}
}

