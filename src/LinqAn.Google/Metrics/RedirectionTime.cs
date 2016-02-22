using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.
	/// </summary>
	[Description("The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.")]
	public class RedirectionTime: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RedirectionTime" />.
		/// </summary>
		public RedirectionTime(): base("Redirection Time (ms)",false,"ga:redirectionTime")
		{
			
		}
	}
}

