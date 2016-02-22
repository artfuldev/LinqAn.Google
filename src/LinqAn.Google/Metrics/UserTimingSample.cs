using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.
	/// </summary>
	[Description("The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.")]
	public class UserTimingSample: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserTimingSample" />.
		/// </summary>
		public UserTimingSample(): base("User Timing Sample",false,"ga:userTimingSample")
		{
			
		}
	}
}

