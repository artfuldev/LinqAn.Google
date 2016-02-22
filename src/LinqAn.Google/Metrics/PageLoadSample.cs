using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The sample set (or count) of pageviews used to calculate the average page load time.
	/// </summary>
	[Description("The sample set (or count) of pageviews used to calculate the average page load time.")]
	public class PageLoadSample: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PageLoadSample" />.
		/// </summary>
		public PageLoadSample(): base("Page Load Sample",false,"ga:pageLoadSample")
		{
			
		}
	}
}

