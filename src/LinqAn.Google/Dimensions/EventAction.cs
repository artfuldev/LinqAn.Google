using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The action of the event.
	/// </summary>
	[Description("The action of the event.")]
	public class EventAction: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="EventAction" />.
		/// </summary>
		public EventAction(): base("Event Action",true,"ga:eventAction")
		{
			
		}
	}
}

