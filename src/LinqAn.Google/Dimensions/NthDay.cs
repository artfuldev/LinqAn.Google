using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Index for each day in the specified date range. Index for the first day (i.e., start-date) in the date range is 0, 1 for the second day, and so on.
	/// </summary>
	[Description("Index for each day in the specified date range. Index for the first day (i.e., start-date) in the date range is 0, 1 for the second day, and so on.")]
	public class NthDay: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="NthDay" />.
		/// </summary>
		public NthDay(): base("Day Index",false,"ga:nthDay")
		{
			
		}
	}
}

