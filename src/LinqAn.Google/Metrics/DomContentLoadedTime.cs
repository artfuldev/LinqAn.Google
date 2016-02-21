namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc.
	/// </summary>
	public class DomContentLoadedTime: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DomContentLoadedTime" />.
		/// </summary>
		public DomContentLoadedTime(): base("Document Content Loaded Time (ms)","The time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the user's location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuery's onready() callback, etc.",false,"ga:domContentLoadedTime")
		{
			
		}
	}
}

