namespace DotNetAnalytics.Google.Metrics
{
	public class EventValueMetric: Metric<int>
	{
		public EventValueMetric(): base("Event Value","The total value of events for the profile.",true,"ga:eventValue")
		{
			
		}
	}
}

