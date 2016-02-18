namespace DotNetAnalytics.Google.Metrics
{
	public class TotalUniqueSearchesMetric: Metric<int>
	{
		/// <summary>
		/// 	The total number of unique keywords from internal searches within a session. For example if "shoes" was searched for 3 times in a session, it will be only counted once.
		/// </summary>
		public TotalUniqueSearchesMetric(): base("Total Unique Searches","The total number of unique keywords from internal searches within a session. For example if "shoes" was searched for 3 times in a session, it will be only counted once.",true,"ga:searchUniques")
		{
			
		}
	}
}

