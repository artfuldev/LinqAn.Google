namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.
	/// </summary>
	public class SpeedMetricsSample: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SpeedMetricsSample" />.
		/// </summary>
		public SpeedMetricsSample(): base("Speed Metrics Sample","The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.",false,"ga:speedMetricsSample")
		{
			
		}
	}
}

