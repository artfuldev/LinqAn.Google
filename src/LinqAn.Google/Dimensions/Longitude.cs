using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values.
	/// </summary>
	[Description("The approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values.")]
	public class Longitude: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Longitude" />.
		/// </summary>
		public Longitude(): base("Longitude",false,"ga:longitude")
		{
			
		}
	}
}

