namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The cities of users, derived from IP addresses or Geographical IDs.
	/// </summary>
	public class CityDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="CityDimension" />.
		/// </summary>
		public CityDimension(): base("City","The cities of users, derived from IP addresses or Geographical IDs.",true,"ga:city")
		{
			
		}
	}
}

