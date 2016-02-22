using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The cities of users, derived from IP addresses or Geographical IDs.
	/// </summary>
	[Description("The cities of users, derived from IP addresses or Geographical IDs.")]
	public class City: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="City" />.
		/// </summary>
		public City(): base("City",true,"ga:city")
		{
			
		}
	}
}

