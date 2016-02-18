using System;

namespace DotNetAnalytics.Google.Metrics
{
	public class SessionDurationMetric: Metric<TimeSpan>
	{
		public SessionDurationMetric(): base("Session Duration","The total duration of user sessions represented in total seconds.",true,"ga:sessionDuration")
		{
			
		}
	}
}

