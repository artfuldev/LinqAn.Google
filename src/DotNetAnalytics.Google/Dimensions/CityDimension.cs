namespace DotNetAnalytics.Google.Dimensions
{
	public class CityDimension: Dimension<string>
	{
		/// <summary>
		/// 	The cities of users, derived from IP addresses or Geographical IDs.
		/// </summary>
		public CityDimension(): base("City","The cities of users, derived from IP addresses or Geographical IDs.",true,"ga:city")
		{
			
		}
	}
}

