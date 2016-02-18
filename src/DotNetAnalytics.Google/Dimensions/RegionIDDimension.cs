namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The region ID of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York. The region IDs are the same as the Criteria IDs found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
	/// </summary>
	public class RegionIDDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="RegionIDDimension" />.
		/// </summary>
		public RegionIDDimension(): base("Region ID","The region ID of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York. The region IDs are the same as the Criteria IDs found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid",false,"ga:regionId")
		{
			
		}
	}
}

