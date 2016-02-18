namespace DotNetAnalytics.Google.Dimensions
{
	public class InternalPromotionIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	The ID of the promotion (Enhanced Ecommerce).
		/// </summary>
		public InternalPromotionIDDimension(): base("Internal Promotion ID","The ID of the promotion (Enhanced Ecommerce).",true,"ga:internalPromotionId")
		{
			
		}
	}
}

