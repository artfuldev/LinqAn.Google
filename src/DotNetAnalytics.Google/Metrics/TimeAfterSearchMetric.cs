using System;

namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The session duration where a use of your internal search feature occurred.
	/// </summary>
	public class TimeAfterSearchMetric: Metric<TimeSpan>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="TimeAfterSearchMetric" />.
		/// </summary>
		public TimeAfterSearchMetric(): base("Time after Search","The session duration where a use of your internal search feature occurred.",true,"ga:searchDuration")
		{
			
		}
	}
}

