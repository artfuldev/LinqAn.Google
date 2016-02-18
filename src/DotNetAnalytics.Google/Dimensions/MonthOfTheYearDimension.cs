namespace DotNetAnalytics.Google.Dimensions
{
	public class MonthOfTheYearDimension: Dimension<string>
	{
		/// <summary>
		/// 	The month of the session. A two digit integer from 01 to 12.
		/// </summary>
		public MonthOfTheYearDimension(): base("Month of the year","The month of the session. A two digit integer from 01 to 12.",false,"ga:month")
		{
			
		}
	}
}

