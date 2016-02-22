using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of sessions with events.
	/// </summary>
	[Description("The total number of sessions with events.")]
	public class SessionsWithEvent: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SessionsWithEvent" />.
		/// </summary>
		public SessionsWithEvent(): base("Sessions with Event",true,"ga:sessionsWithEvent")
		{
			
		}
	}
}

