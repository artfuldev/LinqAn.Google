using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.
	/// </summary>
	[Description("The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.")]
	public class SpeedMetricsSample: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SpeedMetricsSample" />.
		/// </summary>
		public SpeedMetricsSample(): base("Speed Metrics Sample",false,"ga:speedMetricsSample")
		{
			
		}
	}
}

