using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average number of events per session with event.
	/// </summary>
	[Description("The average number of events per session with event.")]
	public class EventsPerSessionWithEvent: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="EventsPerSessionWithEvent" />.
		/// </summary>
		public EventsPerSessionWithEvent(): base("Events / Session with Event",false,"ga:eventsPerSessionWithEvent")
		{
			
		}
	}
}

