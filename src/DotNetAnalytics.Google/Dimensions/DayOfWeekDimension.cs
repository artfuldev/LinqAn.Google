namespace DotNetAnalytics.Google.Dimensions
{
	public class DayOfWeekDimension: Dimension<string>
	{
		/// <summary>
		/// 	The day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday).
		/// </summary>
		public DayOfWeekDimension(): base("Day of Week","The day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday).",false,"ga:dayOfWeek")
		{
			
		}
	}
}

