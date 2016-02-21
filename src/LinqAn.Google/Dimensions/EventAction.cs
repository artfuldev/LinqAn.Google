namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The action of the event.
	/// </summary>
	public class EventAction: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="EventAction" />.
		/// </summary>
		public EventAction(): base("Event Action","The action of the event.",true,"ga:eventAction")
		{
			
		}
	}
}

