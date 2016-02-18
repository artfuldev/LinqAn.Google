namespace DotNetAnalytics.Google.Dimensions
{
	public class MonthOfYearDimension: Dimension<string>
	{
		/// <summary>
		/// 	Combined values of ga:year and ga:month.
		/// </summary>
		public MonthOfYearDimension(): base("Month of Year","Combined values of ga:year and ga:month.",false,"ga:yearMonth")
		{
			
		}
	}
}

