using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The approximate latitude of the user's city. Derived from IP addresses or Geographical IDs. Locations north of the equator are represented by positive values and locations south of the equator by negative values.
	/// </summary>
	[Description("The approximate latitude of the user's city. Derived from IP addresses or Geographical IDs. Locations north of the equator are represented by positive values and locations south of the equator by negative values.")]
	public class Latitude: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Latitude" />.
		/// </summary>
		public Latitude(): base("Latitude",false,"ga:latitude")
		{
			
		}
	}
}

