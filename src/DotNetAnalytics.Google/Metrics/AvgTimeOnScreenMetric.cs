using System;

namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The average amount of time users spent on a screen in seconds.
	/// </summary>
	public class AvgTimeOnScreenMetric: Metric<TimeSpan>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AvgTimeOnScreenMetric" />.
		/// </summary>
		public AvgTimeOnScreenMetric(): base("Avg. Time on Screen","The average amount of time users spent on a screen in seconds.",false,"ga:avgScreenviewDuration")
		{
			
		}
	}
}

