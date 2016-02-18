namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The total value of events for the profile.
	/// </summary>
	public class EventValueMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="EventValueMetric" />.
		/// </summary>
		public EventValueMetric(): base("Event Value","The total value of events for the profile.",true,"ga:eventValue")
		{
			
		}
	}
}

