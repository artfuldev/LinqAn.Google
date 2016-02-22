using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.
	/// </summary>
	[Description("The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.")]
	public class ServerConnectionTime: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ServerConnectionTime" />.
		/// </summary>
		public ServerConnectionTime(): base("Server Connection Time (ms)",false,"ga:serverConnectionTime")
		{
			
		}
	}
}

