namespace DotNetAnalytics.Google.Metrics
{
	public class SpeedMetricsSampleMetric: Metric<int>
	{
		/// <summary>
		/// 	The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.
		/// </summary>
		public SpeedMetricsSampleMetric(): base("Speed Metrics Sample","The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.",false,"ga:speedMetricsSample")
		{
			
		}
	}
}

