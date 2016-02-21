namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total value of events for the profile.
	/// </summary>
	public class EventValue: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="EventValue" />.
		/// </summary>
		public EventValue(): base("Event Value","The total value of events for the profile.",true,"ga:eventValue")
		{
			
		}
	}
}

