namespace DotNetAnalytics.Google.Metrics
{
	public class SessionsMetric: Metric<int>
	{
		public SessionsMetric(): base("Sessions","The total number of sessions.",true,"ga:sessions")
		{
			
		}
	}
}

