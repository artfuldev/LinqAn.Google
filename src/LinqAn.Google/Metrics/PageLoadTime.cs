namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.
	/// </summary>
	public class PageLoadTime: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="PageLoadTime" />.
		/// </summary>
		public PageLoadTime(): base("Page Load Time (ms)","Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.",false,"ga:pageLoadTime")
		{
			
		}
	}
}

