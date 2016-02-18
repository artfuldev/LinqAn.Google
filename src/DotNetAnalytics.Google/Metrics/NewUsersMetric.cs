namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The number of users whose session was marked as a first-time session.
	/// </summary>
	public class NewUsersMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="NewUsersMetric" />.
		/// </summary>
		public NewUsersMetric(): base("New Users","The number of users whose session was marked as a first-time session.",true,"ga:newUsers")
		{
			
		}
	}
}

