namespace DotNetAnalytics.Google.Metrics
{
	public class RedirectionTimeMsMetric: Metric<int>
	{
		public RedirectionTimeMsMetric(): base("Redirection Time (ms)","The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the value for this metric is expected to be 0.",false,"ga:redirectionTime")
		{
			
		}
	}
}

