namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values.
	/// </summary>
	public class Longitude: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Longitude" />.
		/// </summary>
		public Longitude(): base("Longitude","The approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values.",false,"ga:longitude")
		{
			
		}
	}
}

