namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total number of sessions with events.
	/// </summary>
	public class SessionsWithEventMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SessionsWithEventMetric" />.
		/// </summary>
		public SessionsWithEventMetric(): base("Sessions with Event","The total number of sessions with events.",true,"ga:sessionsWithEvent")
		{
			
		}
	}
}

