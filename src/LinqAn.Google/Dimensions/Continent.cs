using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The continents of users, derived from IP addresses or Geographical IDs.
	/// </summary>
	[Description("The continents of users, derived from IP addresses or Geographical IDs.")]
	public class Continent: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Continent" />.
		/// </summary>
		public Continent(): base("Continent",true,"ga:continent")
		{
			
		}
	}
}

