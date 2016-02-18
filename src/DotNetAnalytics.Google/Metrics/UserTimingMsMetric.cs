namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total number of milliseconds for a user timing.
	/// </summary>
	public class UserTimingMsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="UserTimingMsMetric" />.
		/// </summary>
		public UserTimingMsMetric(): base("User Timing (ms)","The total number of milliseconds for a user timing.",false,"ga:userTimingValue")
		{
			
		}
	}
}

