namespace DotNetAnalytics.Google.Dimensions
{
	public class WeekOfTheYearDimension: Dimension<string>
	{
		/// <summary>
		/// 	The week of the session. A two-digit number from 01 to 53. Each week starts on Sunday.
		/// </summary>
		public WeekOfTheYearDimension(): base("Week of the Year","The week of the session. A two-digit number from 01 to 53. Each week starts on Sunday.",false,"ga:week")
		{
			
		}
	}
}

