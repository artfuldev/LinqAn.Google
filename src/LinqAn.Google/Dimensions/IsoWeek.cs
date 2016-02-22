using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The ISO week number, where each week starts with a Monday. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoWeek should only be used with ga:isoYear since ga:year represents gregorian calendar.
	/// </summary>
	[Description("The ISO week number, where each week starts with a Monday. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoWeek should only be used with ga:isoYear since ga:year represents gregorian calendar.")]
	public class IsoWeek: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="IsoWeek" />.
		/// </summary>
		public IsoWeek(): base("ISO Week of the Year",false,"ga:isoWeek")
		{
			
		}
	}
}

