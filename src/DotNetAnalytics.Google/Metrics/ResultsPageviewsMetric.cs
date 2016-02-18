namespace DotNetAnalytics.Google.Metrics
{
	public class ResultsPageviewsMetric: Metric<int>
	{
		public ResultsPageviewsMetric(): base("Results Pageviews","The number of times a search result page was viewed after performing a search.",false,"ga:searchResultViews")
		{
			
		}
	}
}

