namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).
	/// </summary>
	public class TargetingTypeDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="TargetingTypeDimension" />.
		/// </summary>
		public TargetingTypeDimension(): base("Targeting Type","How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).",true,"ga:adTargetingType")
		{
			
		}
	}
}

