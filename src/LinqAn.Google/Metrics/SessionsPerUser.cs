using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of sessions divided by the total number of users.
	/// </summary>
	[Description("The total number of sessions divided by the total number of users.")]
	public class SessionsPerUser: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SessionsPerUser" />.
		/// </summary>
		public SessionsPerUser(): base("Number of Sessions per User",false,"ga:sessionsPerUser")
		{
			
		}
	}
}

