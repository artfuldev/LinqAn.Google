namespace DotNetAnalytics.Google.Dimensions
{
	public class RegionISOCodeDimension: Dimension<string>
	{
		/// <summary>
		/// 	The region ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-2 code.
		/// </summary>
		public RegionISOCodeDimension(): base("Region ISO Code","The region ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-2 code.",false,"ga:regionIsoCode")
		{
			
		}
	}
}

