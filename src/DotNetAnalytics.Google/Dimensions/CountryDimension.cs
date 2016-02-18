namespace DotNetAnalytics.Google.Dimensions
{
	public class CountryDimension: Dimension<string>
	{
		/// <summary>
		/// 	The country of users, derived from IP addresses or Geographical IDs.
		/// </summary>
		public CountryDimension(): base("Country","The country of users, derived from IP addresses or Geographical IDs.",true,"ga:country")
		{
			
		}
	}
}

