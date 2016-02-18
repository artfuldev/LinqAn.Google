namespace DotNetAnalytics.Google.Dimensions
{
	public class PlacementTypeDimension: Dimension<string>
	{
		/// <summary>
		/// 	How you manage your ads on the content network. Values are Automatic placements or Managed placements.
		/// </summary>
		public PlacementTypeDimension(): base("Placement Type","How you manage your ads on the content network. Values are Automatic placements or Managed placements.",false,"ga:adTargetingOption")
		{
			
		}
	}
}

