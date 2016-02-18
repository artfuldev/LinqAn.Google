using System;

namespace DotNetAnalytics.Google.Metrics
{
	public class AvgTimeOnScreenMetric: Metric<TimeSpan>
	{
		/// <summary>
		/// 	The average amount of time users spent on a screen in seconds.
		/// </summary>
		public AvgTimeOnScreenMetric(): base("Avg. Time on Screen","The average amount of time users spent on a screen in seconds.",false,"ga:avgScreenviewDuration")
		{
			
		}
	}
}

