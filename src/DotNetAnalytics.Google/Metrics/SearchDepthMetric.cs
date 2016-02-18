namespace DotNetAnalytics.Google.Metrics
{
	public class SearchDepthMetric: Metric<int>
	{
		public SearchDepthMetric(): base("Search Depth","The total number of subsequent page views made after a use of your internal search feature.",true,"ga:searchDepth")
		{
			
		}
	}
}

