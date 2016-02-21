namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total amount of time (in milliseconds) to download this page among all samples.
	/// </summary>
	public class PageDownloadTime: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="PageDownloadTime" />.
		/// </summary>
		public PageDownloadTime(): base("Page Download Time (ms)","The total amount of time (in milliseconds) to download this page among all samples.",false,"ga:pageDownloadTime")
		{
			
		}
	}
}

