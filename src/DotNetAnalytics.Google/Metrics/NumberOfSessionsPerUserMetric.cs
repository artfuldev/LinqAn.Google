namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total number of sessions divided by the total number of users.
	/// </summary>
	public class NumberOfSessionsPerUserMetric: Metric<float>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="NumberOfSessionsPerUserMetric" />.
		/// </summary>
		public NumberOfSessionsPerUserMetric(): base("Number of Sessions per User","The total number of sessions divided by the total number of users.",false,"ga:sessionsPerUser")
		{
			
		}
	}
}

