namespace DotNetAnalytics.Google.Metrics
{
	public class SearchExitsMetric: Metric<int>
	{
		public SearchExitsMetric(): base("Search Exits","The number of exits on your site that occurred following a search result from your internal search feature.",true,"ga:searchExits")
		{
			
		}
	}
}

