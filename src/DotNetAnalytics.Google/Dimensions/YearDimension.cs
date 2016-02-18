namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The year of the session. A four-digit year from 2005 to the current year.
	/// </summary>
	public class YearDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="YearDimension" />.
		/// </summary>
		public YearDimension(): base("Year","The year of the session. A four-digit year from 2005 to the current year.",false,"ga:year")
		{
			
		}
	}
}

