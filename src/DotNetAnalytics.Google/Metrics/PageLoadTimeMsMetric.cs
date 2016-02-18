namespace DotNetAnalytics.Google.Metrics
{
	public class PageLoadTimeMsMetric: Metric<int>
	{
		public PageLoadTimeMsMetric(): base("Page Load Time (ms)","Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.",false,"ga:pageLoadTime")
		{
			
		}
	}
}

