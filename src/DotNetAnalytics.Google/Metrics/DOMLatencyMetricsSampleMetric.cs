namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.
	/// </summary>
	public class DOMLatencyMetricsSampleMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DOMLatencyMetricsSampleMetric" />.
		/// </summary>
		public DOMLatencyMetricsSampleMetric(): base("DOM Latency Metrics Sample","The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.",false,"ga:domLatencyMetricsSample")
		{
			
		}
	}
}

