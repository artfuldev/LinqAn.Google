namespace DotNetAnalytics.Google.Metrics
{
	public class UniqueEventsMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of unique events. Events in different sessions count as separate events.
		/// </summary>
		public UniqueEventsMetric(): base("Unique Events","The number of unique events. Events in different sessions count as separate events.",false,"ga:uniqueEvents")
		{
			
		}
	}
}

