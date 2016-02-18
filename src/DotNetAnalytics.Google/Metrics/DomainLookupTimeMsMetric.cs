namespace DotNetAnalytics.Google.Metrics
{
	public class DomainLookupTimeMsMetric: Metric<int>
	{
		/// <summary>
		/// 	The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.
		/// </summary>
		public DomainLookupTimeMsMetric(): base("Domain Lookup Time (ms)","The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.",false,"ga:domainLookupTime")
		{
			
		}
	}
}

