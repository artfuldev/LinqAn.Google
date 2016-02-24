using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average amount of time (in seconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.
	/// </summary>
	[Description("The average amount of time (in seconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.")]
	public class AvgPageLoadTime: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgPageLoadTime" />.
		/// </summary>
		public AvgPageLoadTime(): base("Avg. Page Load Time (sec)",false,"ga:avgPageLoadTime")
		{
			
		}
	}
}

