namespace DotNetAnalytics.Google.Dimensions
{
	public class PlacementURLDimension: Dimension<string>
	{
		/// <summary>
		/// 	The URLs where your ads on the content network were placed.
		/// </summary>
		public PlacementURLDimension(): base("Placement URL","The URLs where your ads on the content network were placed.",false,"ga:adPlacementUrl")
		{
			
		}
	}
}

