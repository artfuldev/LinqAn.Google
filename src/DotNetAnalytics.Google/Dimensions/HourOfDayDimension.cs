namespace DotNetAnalytics.Google.Dimensions
{
	public class HourOfDayDimension: Dimension<string>
	{
		/// <summary>
		/// 	Combined values of ga:date and ga:hour.
		/// </summary>
		public HourOfDayDimension(): base("Hour of Day","Combined values of ga:date and ga:hour.",false,"ga:dateHour")
		{
			
		}
	}
}

