namespace DotNetAnalytics.Google.Metrics
{
	/// <summary>
	/// 	The number of exits on your site that occurred following a search result from your internal search feature.
	/// </summary>
	public class SearchExitsMetric: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SearchExitsMetric" />.
		/// </summary>
		public SearchExitsMetric(): base("Search Exits","The number of exits on your site that occurred following a search result from your internal search feature.",true,"ga:searchExits")
		{
			
		}
	}
}

