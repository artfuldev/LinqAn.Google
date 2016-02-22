using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.
	/// </summary>
	[Description("The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.")]
	public class ServerResponseTime: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ServerResponseTime" />.
		/// </summary>
		public ServerResponseTime(): base("Server Response Time (ms)",false,"ga:serverResponseTime")
		{
			
		}
	}
}

