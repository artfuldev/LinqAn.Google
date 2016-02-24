using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average amount of time (in seconds) your server takes to respond to a user request, including the network time from user's location to your server.
	/// </summary>
	[Description("The average amount of time (in seconds) your server takes to respond to a user request, including the network time from user's location to your server.")]
	public class AvgServerResponseTime: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgServerResponseTime" />.
		/// </summary>
		public AvgServerResponseTime(): base("Avg. Server Response Time (sec)",false,"ga:avgServerResponseTime")
		{
			
		}
	}
}

