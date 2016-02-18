namespace DotNetAnalytics.Google.Dimensions
{
	public class MinuteIndexDimension: Dimension<string>
	{
		/// <summary>
		/// 	Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on.
		/// </summary>
		public MinuteIndexDimension(): base("Minute Index","Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on.",false,"ga:nthMinute")
		{
			
		}
	}
}

