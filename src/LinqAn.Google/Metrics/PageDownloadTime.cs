using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total amount of time (in milliseconds) to download this page among all samples.
	/// </summary>
	[Description("The total amount of time (in milliseconds) to download this page among all samples.")]
	public class PageDownloadTime: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PageDownloadTime" />.
		/// </summary>
		public PageDownloadTime(): base("Page Download Time (ms)",false,"ga:pageDownloadTime")
		{
			
		}
	}
}

