namespace DotNetAnalytics.Google.Dimensions
{
	public class ISOWeekOfTheYearDimension: Dimension<string>
	{
		/// <summary>
		/// 	The ISO week number, where each week starts with a Monday. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoWeek should only be used with ga:isoYear since ga:year represents gregorian calendar.
		/// </summary>
		public ISOWeekOfTheYearDimension(): base("ISO Week of the Year","The ISO week number, where each week starts with a Monday. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoWeek should only be used with ga:isoYear since ga:year represents gregorian calendar.",false,"ga:isoWeek")
		{
			
		}
	}
}

