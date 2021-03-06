using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.
	/// </summary>
	[Description("The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the user's location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.")]
	public class DomInteractiveTime: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DomInteractiveTime" />.
		/// </summary>
		public DomInteractiveTime(): base("Document Interactive Time (ms)",false,"ga:domInteractiveTime")
		{
			
		}
	}
}

