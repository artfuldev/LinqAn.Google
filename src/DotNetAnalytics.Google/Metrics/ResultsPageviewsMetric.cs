namespace DotNetAnalytics.Google.Metrics
{
	public class ResultsPageviewsMetric: Metric<int>
	{
		/// <summary>
		/// 	The number of times a search result page was viewed after performing a search.
		/// </summary>
		public ResultsPageviewsMetric(): base("Results Pageviews","The number of times a search result page was viewed after performing a search.",false,"ga:searchResultViews")
		{
			
		}
	}
}

