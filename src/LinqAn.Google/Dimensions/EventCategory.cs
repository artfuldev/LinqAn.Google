using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The category of the event.
	/// </summary>
	[Description("The category of the event.")]
	public class EventCategory: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="EventCategory" />.
		/// </summary>
		public EventCategory(): base("Event Category",true,"ga:eventCategory")
		{
			
		}
	}
}

