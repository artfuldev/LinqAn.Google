using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average time (in seconds) it takes the browser to parse the document and execute deferred and parser-inserted scripts including the network time from the user's location to your server.
	/// </summary>
	[Description("The average time (in seconds) it takes the browser to parse the document and execute deferred and parser-inserted scripts including the network time from the user's location to your server.")]
	public class AvgDomInteractiveTime: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgDomInteractiveTime" />.
		/// </summary>
		public AvgDomInteractiveTime(): base("Avg. Document Interactive Time (sec)",false,"ga:avgDomInteractiveTime")
		{
			
		}
	}
}

