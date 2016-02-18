namespace DotNetAnalytics.Google.Dimensions
{
	public class DayOfTheMonthDimension: Dimension<string>
	{
		/// <summary>
		/// 	The day of the month. A two-digit number from 01 to 31.
		/// </summary>
		public DayOfTheMonthDimension(): base("Day of the month","The day of the month. A two-digit number from 01 to 31.",false,"ga:day")
		{
			
		}
	}
}

