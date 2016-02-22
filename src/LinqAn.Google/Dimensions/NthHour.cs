using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Index for each hour in the specified date range. Index for the first hour of first day (i.e., start-date) in the date range is 0, 1 for the next hour, and so on.
	/// </summary>
	[Description("Index for each hour in the specified date range. Index for the first hour of first day (i.e., start-date) in the date range is 0, 1 for the next hour, and so on.")]
	public class NthHour: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="NthHour" />.
		/// </summary>
		public NthHour(): base("Hour Index",false,"ga:nthHour")
		{
			
		}
	}
}

