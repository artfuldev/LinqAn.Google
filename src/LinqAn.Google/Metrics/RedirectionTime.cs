namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.
	/// </summary>
	public class RedirectionTime: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="RedirectionTime" />.
		/// </summary>
		public RedirectionTime(): base("Redirection Time (ms)","The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.",false,"ga:redirectionTime")
		{
			
		}
	}
}

