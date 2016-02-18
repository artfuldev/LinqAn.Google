namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The country of users, derived from IP addresses or Geographical IDs.
	/// </summary>
	public class CountryDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="CountryDimension" />.
		/// </summary>
		public CountryDimension(): base("Country","The country of users, derived from IP addresses or Geographical IDs.",true,"ga:country")
		{
			
		}
	}
}

