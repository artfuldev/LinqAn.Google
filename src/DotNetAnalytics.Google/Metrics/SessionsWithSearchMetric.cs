namespace DotNetAnalytics.Google.Metrics
{
	public class SessionsWithSearchMetric: Metric<int>
	{
		public SessionsWithSearchMetric(): base("Sessions with Search","The total number of sessions that included an internal search",true,"ga:searchSessions")
		{
			
		}
	}
}

