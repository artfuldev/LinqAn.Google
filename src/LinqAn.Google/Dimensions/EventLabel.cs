using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The label of the event.
	/// </summary>
	[Description("The label of the event.")]
	public class EventLabel: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="EventLabel" />.
		/// </summary>
		public EventLabel(): base("Event Label",true,"ga:eventLabel")
		{
			
		}
	}
}

