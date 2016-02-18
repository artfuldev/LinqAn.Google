namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The number of unique events. Events in different sessions count as separate events.
	/// </summary>
	public class UniqueEventsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="UniqueEventsMetric" />.
		/// </summary>
		public UniqueEventsMetric(): base("Unique Events","The number of unique events. Events in different sessions count as separate events.",false,"ga:uniqueEvents")
		{
			
		}
	}
}

