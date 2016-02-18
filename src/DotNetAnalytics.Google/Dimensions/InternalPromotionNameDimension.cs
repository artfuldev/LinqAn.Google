namespace DotNetAnalytics.Google.Dimensions
{
	public class InternalPromotionNameDimension: Dimension<string>
	{
		/// <summary>
		/// 	The name of the promotion (Enhanced Ecommerce).
		/// </summary>
		public InternalPromotionNameDimension(): base("Internal Promotion Name","The name of the promotion (Enhanced Ecommerce).",true,"ga:internalPromotionName")
		{
			
		}
	}
}

