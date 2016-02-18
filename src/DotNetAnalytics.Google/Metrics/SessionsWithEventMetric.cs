namespace DotNetAnalytics.Google.Metrics
{
	public class SessionsWithEventMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of sessions with events.
		/// </summary>
		public SessionsWithEventMetric(): base("Sessions with Event","The total number of sessions with events.",true,"ga:sessionsWithEvent")
		{
			
		}
	}
}

