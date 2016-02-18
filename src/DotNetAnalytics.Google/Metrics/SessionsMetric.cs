namespace DotNetAnalytics.Google.Metrics
{
	public class SessionsMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of sessions.
		/// </summary>
		public SessionsMetric(): base("Sessions","The total number of sessions.",true,"ga:sessions")
		{
			
		}
	}
}

