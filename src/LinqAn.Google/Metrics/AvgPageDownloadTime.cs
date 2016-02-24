using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average amount of time (in seconds) to download this page.
	/// </summary>
	[Description("The average amount of time (in seconds) to download this page.")]
	public class AvgPageDownloadTime: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgPageDownloadTime" />.
		/// </summary>
		public AvgPageDownloadTime(): base("Avg. Page Download Time (sec)",false,"ga:avgPageDownloadTime")
		{
			
		}
	}
}

