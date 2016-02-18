namespace DotNetAnalytics.Google.Metrics
{
	public class UsersMetric: Metric<int>
	{
		public UsersMetric(): base("Users","The total number of users for the requested time period.",false,"ga:users")
		{
			
		}
	}
}

