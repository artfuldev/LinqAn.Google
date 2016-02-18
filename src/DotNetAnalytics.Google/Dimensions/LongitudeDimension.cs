namespace DotNetAnalytics.Google.Dimensions
{
	public class LongitudeDimension: Dimension<string>
	{
		/// <summary>
		/// 	The approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values.
		/// </summary>
		public LongitudeDimension(): base("Longitude","The approximate longitude of the user's city. Derived from IP addresses or Geographical IDs. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values.",false,"ga:longitude")
		{
			
		}
	}
}

