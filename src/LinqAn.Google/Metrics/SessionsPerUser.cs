namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of sessions divided by the total number of users.
	/// </summary>
	public class SessionsPerUser: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SessionsPerUser" />.
		/// </summary>
		public SessionsPerUser(): base("Number of Sessions per User","The total number of sessions divided by the total number of users.",false,"ga:sessionsPerUser")
		{
			
		}
	}
}

