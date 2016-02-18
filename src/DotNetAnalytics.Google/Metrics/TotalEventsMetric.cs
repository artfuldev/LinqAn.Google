namespace DotNetAnalytics.Google.Metrics
{
	public class TotalEventsMetric: Metric<int>
	{
		public TotalEventsMetric(): base("Total Events","The total number of events for the profile, across all categories.",true,"ga:totalEvents")
		{
			
		}
	}
}

