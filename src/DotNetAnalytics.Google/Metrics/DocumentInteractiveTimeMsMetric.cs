namespace DotNetAnalytics.Google.Metrics
{
	public class DocumentInteractiveTimeMsMetric: Metric<int>
	{
		/// <summary>
		/// 	The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.
		/// </summary>
		public DocumentInteractiveTimeMsMetric(): base("Document Interactive Time (ms)","The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.",false,"ga:domInteractiveTime")
		{
			
		}
	}
}

