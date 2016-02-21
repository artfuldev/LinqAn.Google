namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The region ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-2 code.
	/// </summary>
	public class RegionIsoCode: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RegionIsoCode" />.
		/// </summary>
		public RegionIsoCode(): base("Region ISO Code","The region ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-2 code.",false,"ga:regionIsoCode")
		{
			
		}
	}
}

