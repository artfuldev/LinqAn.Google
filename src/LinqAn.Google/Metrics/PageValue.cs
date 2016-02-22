using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).
	/// </summary>
	[Description("The average value of this page or set of pages. Page Value is (ga:transactionRevenue + ga:goalValueAll) / ga:uniquePageviews (for the page or set of pages).")]
	public class PageValue: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PageValue" />.
		/// </summary>
		public PageValue(): base("Page Value",false,"ga:pageValue")
		{
			
		}
	}
}

