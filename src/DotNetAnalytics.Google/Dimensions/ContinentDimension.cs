namespace DotNetAnalytics.Google.Dimensions
{
	public class ContinentDimension: Dimension<string>
	{
		/// <summary>
		/// 	The continents of users, derived from IP addresses or Geographical IDs.
		/// </summary>
		public ContinentDimension(): base("Continent","The continents of users, derived from IP addresses or Geographical IDs.",true,"ga:continent")
		{
			
		}
	}
}

