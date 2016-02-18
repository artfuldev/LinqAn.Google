namespace DotNetAnalytics.Google.Metrics
{
	public class NumberOfSessionsPerUserMetric: Metric<float>
	{
		public NumberOfSessionsPerUserMetric(): base("Number of Sessions per User","The total number of sessions divided by the total number of users.",false,"ga:sessionsPerUser")
		{
			
		}
	}
}

