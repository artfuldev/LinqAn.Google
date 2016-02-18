namespace DotNetAnalytics.Google.Metrics
{
	public class OrganicSearchesMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of organic searches that happened within a session. This metric is search engine agnostic.
		/// </summary>
		public OrganicSearchesMetric(): base("Organic Searches","The number of organic searches that happened within a session. This metric is search engine agnostic.",false,"ga:organicSearches")
		{
			
		}
	}
}

