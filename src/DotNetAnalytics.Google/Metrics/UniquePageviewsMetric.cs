namespace DotNetAnalytics.Google.Metrics
{
	public class UniquePageviewsMetric: Metric<int>
	{
		public UniquePageviewsMetric(): base("Unique Pageviews","The number of unique page views. Page views within different sessions count as separate unique page views. This takes into account both the pagePath and pageTitle to determine uniqueness.",true,"ga:uniquePageviews")
		{
			
		}
	}
}

