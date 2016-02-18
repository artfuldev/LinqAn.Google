namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The ISO year of the session. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoYear should only be used with ga:isoWeek since ga:week represents gregorian calendar.
	/// </summary>
	public class ISOYearDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ISOYearDimension" />.
		/// </summary>
		public ISOYearDimension(): base("ISO Year","The ISO year of the session. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoYear should only be used with ga:isoWeek since ga:week represents gregorian calendar.",false,"ga:isoYear")
		{
			
		}
	}
}

