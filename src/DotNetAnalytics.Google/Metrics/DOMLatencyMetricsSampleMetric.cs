namespace DotNetAnalytics.Google.Metrics
{
	public class DOMLatencyMetricsSampleMetric: Metric<int>
	{
		public DOMLatencyMetricsSampleMetric(): base("DOM Latency Metrics Sample","The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.",false,"ga:domLatencyMetricsSample")
		{
			
		}
	}
}

