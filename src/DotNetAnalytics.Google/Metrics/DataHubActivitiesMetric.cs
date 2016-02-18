namespace DotNetAnalytics.Google.Metrics
{
	public class DataHubActivitiesMetric: Metric<int>
	{
		public DataHubActivitiesMetric(): base("Data Hub Activities","The total number of activities where a content URL was shared / mentioned on a social data hub partner network.",false,"ga:socialActivities")
		{
			
		}
	}
}

