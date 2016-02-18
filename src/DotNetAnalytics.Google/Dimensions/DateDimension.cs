namespace DotNetAnalytics.Google.Dimensions
{
	public class DateDimension: Dimension<string>
	{
		/// <summary>
		/// 	The date of the session formatted as YYYYMMDD.
		/// </summary>
		public DateDimension(): base("Date","The date of the session formatted as YYYYMMDD.",false,"ga:date")
		{
			
		}
	}
}

