using System;

namespace DotNetAnalytics.Google.Metrics
{
	public class TimeOnScreenMetric: Metric<TimeSpan>
	{
		/// <summary>
		/// 	The time spent viewing the current screen.
		/// </summary>
		public TimeOnScreenMetric(): base("Time on Screen","The time spent viewing the current screen.",true,"ga:timeOnScreen")
		{
			
		}
	}
}

