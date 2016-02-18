namespace DotNetAnalytics.Google.Metrics
{
	public class NewUsersMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of users whose session was marked as a first-time session.
		/// </summary>
		public NewUsersMetric(): base("New Users","The number of users whose session was marked as a first-time session.",true,"ga:newUsers")
		{
			
		}
	}
}

