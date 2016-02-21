namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of exits on your site that occurred following a search result from your internal search feature.
	/// </summary>
	public class SearchExits: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchExits" />.
		/// </summary>
		public SearchExits(): base("Search Exits","The number of exits on your site that occurred following a search result from your internal search feature.",true,"ga:searchExits")
		{
			
		}
	}
}

