namespace DotNetAnalytics.Google.Dimensions
{
	public class YearDimension: Dimension<string>
	{
		/// <summary>
		/// 	The year of the session. A four-digit year from 2005 to the current year.
		/// </summary>
		public YearDimension(): base("Year","The year of the session. A four-digit year from 2005 to the current year.",false,"ga:year")
		{
			
		}
	}
}

