namespace DotNetAnalytics.Google.Metrics
{
	public class DomainLookupTimeMsMetric: Metric<int>
	{
		public DomainLookupTimeMsMetric(): base("Domain Lookup Time (ms)","The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.",false,"ga:domainLookupTime")
		{
			
		}
	}
}

