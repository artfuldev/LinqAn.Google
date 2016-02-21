namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The URLs where your ads on the content network were placed.
	/// </summary>
	public class AdPlacementUrl: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdPlacementUrl" />.
		/// </summary>
		public AdPlacementUrl(): base("Placement URL","The URLs where your ads on the content network were placed.",false,"ga:adPlacementUrl")
		{
			
		}
	}
}

