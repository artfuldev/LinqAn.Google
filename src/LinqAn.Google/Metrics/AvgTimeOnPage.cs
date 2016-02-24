using System.ComponentModel;
using System;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average amount of time users spent viewing this page or a set of pages.
	/// </summary>
	[Description("The average amount of time users spent viewing this page or a set of pages.")]
	public class AvgTimeOnPage: Metric<TimeSpan>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgTimeOnPage" />.
		/// </summary>
		public AvgTimeOnPage(): base("Avg. Time on Page",false,"ga:avgTimeOnPage")
		{
			
		}
	}
}

