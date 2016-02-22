using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of milliseconds for a user timing.
	/// </summary>
	[Description("The total number of milliseconds for a user timing.")]
	public class UserTimingValue: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserTimingValue" />.
		/// </summary>
		public UserTimingValue(): base("User Timing (ms)",false,"ga:userTimingValue")
		{
			
		}
	}
}

