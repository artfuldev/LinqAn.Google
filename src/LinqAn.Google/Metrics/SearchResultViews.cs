namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times a search result page was viewed after performing a search.
	/// </summary>
	public class SearchResultViews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchResultViews" />.
		/// </summary>
		public SearchResultViews(): base("Results Pageviews","The number of times a search result page was viewed after performing a search.",false,"ga:searchResultViews")
		{
			
		}
	}
}

