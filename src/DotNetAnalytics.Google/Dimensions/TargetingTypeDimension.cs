namespace DotNetAnalytics.Google.Dimensions
{
	public class TargetingTypeDimension: Dimension<string>
	{
		/// <summary>
		/// 	How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).
		/// </summary>
		public TargetingTypeDimension(): base("Targeting Type","How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).",true,"ga:adTargetingType")
		{
			
		}
	}
}

