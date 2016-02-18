namespace DotNetAnalytics.Google.Dimensions
{
	public class ISOWeekOfISOYearDimension: Dimension<string>
	{
		/// <summary>
		/// 	Combined values of ga:isoYear and ga:isoWeek.
		/// </summary>
		public ISOWeekOfISOYearDimension(): base("ISO Week of ISO Year","Combined values of ga:isoYear and ga:isoWeek.",false,"ga:isoYearIsoWeek")
		{
			
		}
	}
}

