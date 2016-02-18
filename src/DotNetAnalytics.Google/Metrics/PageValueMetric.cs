namespace DotNetAnalytics.Google.Metrics
{
	public class PageValueMetric: Metric<decimal>
	{
		public PageValueMetric(): base("Page Value","The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).",false,"ga:pageValue")
		{
			
		}
	}
}

