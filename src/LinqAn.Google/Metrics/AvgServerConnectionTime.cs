using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average amount of time (in seconds) spent in establishing TCP connection for this page.
	/// </summary>
	[Description("The average amount of time (in seconds) spent in establishing TCP connection for this page.")]
	public class AvgServerConnectionTime: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgServerConnectionTime" />.
		/// </summary>
		public AvgServerConnectionTime(): base("Avg. Server Connection Time (sec)",false,"ga:avgServerConnectionTime")
		{
			
		}
	}
}

