using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.
	/// </summary>
	[Description("The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.")]
	public class DomLatencyMetricsSample: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DomLatencyMetricsSample" />.
		/// </summary>
		public DomLatencyMetricsSample(): base("DOM Latency Metrics Sample",false,"ga:domLatencyMetricsSample")
		{
			
		}
	}
}

