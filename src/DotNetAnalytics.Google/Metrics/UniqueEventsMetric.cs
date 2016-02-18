namespace DotNetAnalytics.Google.Metrics
{
	public class UniqueEventsMetric: Metric<int>
	{
		public UniqueEventsMetric(): base("Unique Events","The number of unique events. Events in different sessions count as separate events.",false,"ga:uniqueEvents")
		{
			
		}
	}
}

