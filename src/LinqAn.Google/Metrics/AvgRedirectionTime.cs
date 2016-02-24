using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average amount of time (in seconds) spent in redirects before fetching this page. If there are no redirects, the value for this metric is expected to be 0.
	/// </summary>
	[Description("The average amount of time (in seconds) spent in redirects before fetching this page. If there are no redirects, the value for this metric is expected to be 0.")]
	public class AvgRedirectionTime: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgRedirectionTime" />.
		/// </summary>
		public AvgRedirectionTime(): base("Avg. Redirection Time (sec)",false,"ga:avgRedirectionTime")
		{
			
		}
	}
}

