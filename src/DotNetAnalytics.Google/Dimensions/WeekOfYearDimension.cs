namespace DotNetAnalytics.Google.Dimensions
{
	public class WeekOfYearDimension: Dimension<string>
	{
		/// <summary>
		/// 	Combined values of ga:year and ga:week.
		/// </summary>
		public WeekOfYearDimension(): base("Week of Year","Combined values of ga:year and ga:week.",false,"ga:yearWeek")
		{
			
		}
	}
}

