using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The region ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-2 code.
	/// </summary>
	[Description("The region ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-2 code.")]
	public class RegionIsoCode: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RegionIsoCode" />.
		/// </summary>
		public RegionIsoCode(): base("Region ISO Code",false,"ga:regionIsoCode")
		{
			
		}
	}
}

