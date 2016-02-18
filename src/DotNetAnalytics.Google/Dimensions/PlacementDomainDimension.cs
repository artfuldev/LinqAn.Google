namespace DotNetAnalytics.Google.Dimensions
{
	public class PlacementDomainDimension: Dimension<string>
	{
		/// <summary>
		/// 	The domains where your ads on the content network were placed.
		/// </summary>
		public PlacementDomainDimension(): base("Placement Domain","The domains where your ads on the content network were placed.",false,"ga:adPlacementDomain")
		{
			
		}
	}
}

