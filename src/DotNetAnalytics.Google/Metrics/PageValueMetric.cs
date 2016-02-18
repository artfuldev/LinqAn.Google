namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).
	/// </summary>
	public class PageValueMetric: Metric<decimal>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="PageValueMetric" />.
		/// </summary>
		public PageValueMetric(): base("Page Value","The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).",false,"ga:pageValue")
		{
			
		}
	}
}

