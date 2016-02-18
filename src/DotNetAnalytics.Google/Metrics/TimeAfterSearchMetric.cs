using System;

namespace DotNetAnalytics.Google.Metrics
{
	public class TimeAfterSearchMetric: Metric<TimeSpan>
	{
		/// <summary>
		/// 	The session duration where a use of your internal search feature occurred.
		/// </summary>
		public TimeAfterSearchMetric(): base("Time after Search","The session duration where a use of your internal search feature occurred.",true,"ga:searchDuration")
		{
			
		}
	}
}

