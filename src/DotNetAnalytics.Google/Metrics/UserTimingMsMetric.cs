namespace DotNetAnalytics.Google.Metrics
{
	public class UserTimingMsMetric: Metric<int>
	{
		public UserTimingMsMetric(): base("User Timing (ms)","The total number of milliseconds for a user timing.",false,"ga:userTimingValue")
		{
			
		}
	}
}

