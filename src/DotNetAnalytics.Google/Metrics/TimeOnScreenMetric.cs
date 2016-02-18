using System;

namespace DotNetAnalytics.Google.Metrics
{
	public class TimeOnScreenMetric: Metric<TimeSpan>
	{
		public TimeOnScreenMetric(): base("Time on Screen","The time spent viewing the current screen.",true,"ga:timeOnScreen")
		{
			
		}
	}
}

