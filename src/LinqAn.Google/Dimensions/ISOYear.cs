namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The ISO year of the session. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoYear should only be used with ga:isoWeek since ga:week represents gregorian calendar.
	/// </summary>
	public class IsoYear: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="IsoYear" />.
		/// </summary>
		public IsoYear(): base("ISO Year","The ISO year of the session. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoYear should only be used with ga:isoWeek since ga:week represents gregorian calendar.",false,"ga:isoYear")
		{
			
		}
	}
}

