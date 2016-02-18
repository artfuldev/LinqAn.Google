namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The domains where your ads on the content network were placed.
	/// </summary>
	public class PlacementDomainDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="PlacementDomainDimension" />.
		/// </summary>
		public PlacementDomainDimension(): base("Placement Domain","The domains where your ads on the content network were placed.",false,"ga:adPlacementDomain")
		{
			
		}
	}
}

