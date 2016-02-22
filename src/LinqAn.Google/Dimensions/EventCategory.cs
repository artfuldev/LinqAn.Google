namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The category of the event.
	/// </summary>
	public class EventCategory: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="EventCategory" />.
		/// </summary>
		public EventCategory(): base("Event Category","The category of the event.",true,"ga:eventCategory")
		{
			
		}
	}
}

