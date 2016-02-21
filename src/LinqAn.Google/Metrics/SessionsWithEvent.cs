namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of sessions with events.
	/// </summary>
	public class SessionsWithEvent: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SessionsWithEvent" />.
		/// </summary>
		public SessionsWithEvent(): base("Sessions with Event","The total number of sessions with events.",true,"ga:sessionsWithEvent")
		{
			
		}
	}
}

