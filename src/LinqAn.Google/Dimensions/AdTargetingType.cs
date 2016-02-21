namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).
	/// </summary>
	public class AdTargetingType: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdTargetingType" />.
		/// </summary>
		public AdTargetingType(): base("Targeting Type","How your AdWords ads were targeted (keyword, placement, and vertical targeting, etc.).",true,"ga:adTargetingType")
		{
			
		}
	}
}

