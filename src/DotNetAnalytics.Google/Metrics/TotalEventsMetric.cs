namespace DotNetAnalytics.Google.Metrics
{
	public class TotalEventsMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of events for the profile, across all categories.
		/// </summary>
		public TotalEventsMetric(): base("Total Events","The total number of events for the profile, across all categories.",true,"ga:totalEvents")
		{
			
		}
	}
}

