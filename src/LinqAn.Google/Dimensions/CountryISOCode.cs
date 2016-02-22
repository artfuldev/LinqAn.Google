using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The country ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-1 alpha-2 code.
	/// </summary>
	[Description("The country ISO code of users, derived from IP addresses or Geographical IDs. Values are given as an ISO-3166-1 alpha-2 code.")]
	public class CountryIsoCode: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CountryIsoCode" />.
		/// </summary>
		public CountryIsoCode(): base("Country ISO Code",false,"ga:countryIsoCode")
		{
			
		}
	}
}

