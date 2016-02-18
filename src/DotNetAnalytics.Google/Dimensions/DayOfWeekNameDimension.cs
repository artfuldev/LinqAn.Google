namespace DotNetAnalytics.Google.Dimensions
{
	public class DayOfWeekNameDimension: Dimension<string>
	{
		/// <summary>
		/// 	The name of the day of the week (in English).
		/// </summary>
		public DayOfWeekNameDimension(): base("Day of Week Name","The name of the day of the week (in English).",false,"ga:dayOfWeekName")
		{
			
		}
	}
}

