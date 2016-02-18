namespace DotNetAnalytics.Google.Dimensions
{
	public class CityIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	The city IDs of users, derived from IP addresses or Geographical IDs. The city IDs are the same as the Criteria IDs found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid
		/// </summary>
		public CityIDDimension(): base("City ID","The city IDs of users, derived from IP addresses or Geographical IDs. The city IDs are the same as the Criteria IDs found at: https://developers.google.com/analytics/devguides/collection/protocol/v1/geoid",false,"ga:cityId")
		{
			
		}
	}
}

