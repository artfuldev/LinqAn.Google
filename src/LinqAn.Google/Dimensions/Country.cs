using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The country of users, derived from IP addresses or Geographical IDs.
	/// </summary>
	[Description("The country of users, derived from IP addresses or Geographical IDs.")]
	public class Country: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Country" />.
		/// </summary>
		public Country(): base("Country",true,"ga:country")
		{
			
		}
	}
}

