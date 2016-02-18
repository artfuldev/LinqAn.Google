namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:date and ga:hour.
	/// </summary>
	public class HourOfDayDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="HourOfDayDimension" />.
		/// </summary>
		public HourOfDayDimension(): base("Hour of Day","Combined values of ga:date and ga:hour.",false,"ga:dateHour")
		{
			
		}
	}
}

