namespace DotNetAnalytics.Google.Metrics
{
	public class UserTimingMsMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of milliseconds for a user timing.
		/// </summary>
		public UserTimingMsMetric(): base("User Timing (ms)","The total number of milliseconds for a user timing.",false,"ga:userTimingValue")
		{
			
		}
	}
}

