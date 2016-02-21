namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).
	/// </summary>
	public class PageValue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PageValue" />.
		/// </summary>
		public PageValue(): base("Page Value","The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).",false,"ga:pageValue")
		{
			
		}
	}
}

