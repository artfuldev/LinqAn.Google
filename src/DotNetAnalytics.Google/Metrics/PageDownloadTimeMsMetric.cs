namespace DotNetAnalytics.Google.Metrics
{
	public class PageDownloadTimeMsMetric: Metric<int>
	{
		/// <summary>
		/// 	The total amount of time (in milliseconds) to download this page among all samples.
		/// </summary>
		public PageDownloadTimeMsMetric(): base("Page Download Time (ms)","The total amount of time (in milliseconds) to download this page among all samples.",false,"ga:pageDownloadTime")
		{
			
		}
	}
}

