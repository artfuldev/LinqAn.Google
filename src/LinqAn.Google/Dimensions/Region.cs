using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The region of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York.
	/// </summary>
	[Description("The region of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York.")]
	public class Region: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Region" />.
		/// </summary>
		public Region(): base("Region",true,"ga:region")
		{
			
		}
	}
}

