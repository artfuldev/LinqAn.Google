namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The approximate latitude of the user's city. Derived from IP addresses or Geographical IDs. Locations north of the equator are represented by positive values and locations south of the equator by negative values.
	/// </summary>
	public class LatitudeDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="LatitudeDimension" />.
		/// </summary>
		public LatitudeDimension(): base("Latitude","The approximate latitude of the user's city. Derived from IP addresses or Geographical IDs. Locations north of the equator are represented by positive values and locations south of the equator by negative values.",false,"ga:latitude")
		{
			
		}
	}
}

