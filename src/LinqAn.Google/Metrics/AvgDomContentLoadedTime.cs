using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average time (in seconds) it takes the browser to parse the document.
	/// </summary>
	[Description("The average time (in seconds) it takes the browser to parse the document.")]
	public class AvgDomContentLoadedTime: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgDomContentLoadedTime" />.
		/// </summary>
		public AvgDomContentLoadedTime(): base("Avg. Document Content Loaded Time (sec)",false,"ga:avgDomContentLoadedTime")
		{
			
		}
	}
}

