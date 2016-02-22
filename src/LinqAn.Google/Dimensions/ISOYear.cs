using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The ISO year of the session. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoYear should only be used with ga:isoWeek since ga:week represents gregorian calendar.
	/// </summary>
	[Description("The ISO year of the session. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoYear should only be used with ga:isoWeek since ga:week represents gregorian calendar.")]
	public class IsoYear: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="IsoYear" />.
		/// </summary>
		public IsoYear(): base("ISO Year",false,"ga:isoYear")
		{
			
		}
	}
}

