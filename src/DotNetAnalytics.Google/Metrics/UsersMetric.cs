namespace DotNetAnalytics.Google.Metrics
{
	public class UsersMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of users for the requested time period.
		/// </summary>
		public UsersMetric(): base("Users","The total number of users for the requested time period.",false,"ga:users")
		{
			
		}
	}
}

