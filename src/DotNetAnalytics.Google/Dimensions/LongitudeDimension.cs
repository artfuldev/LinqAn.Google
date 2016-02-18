namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values.
	/// </summary>
	public class LongitudeDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="LongitudeDimension" />.
		/// </summary>
		public LongitudeDimension(): base("Longitude","The approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values.",false,"ga:longitude")
		{
			
		}
	}
}

