using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on.
	/// </summary>
	[Description("Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on.")]
	public class NthMinute: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="NthMinute" />.
		/// </summary>
		public NthMinute(): base("Minute Index",false,"ga:nthMinute")
		{
			
		}
	}
}

