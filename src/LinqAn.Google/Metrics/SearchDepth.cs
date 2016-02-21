namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of subsequent page views made after a use of your internal search feature.
	/// </summary>
	public class SearchDepth: Metric<int>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SearchDepth" />.
		/// </summary>
		public SearchDepth(): base("Search Depth","The total number of subsequent page views made after a use of your internal search feature.",true,"ga:searchDepth")
		{
			
		}
	}
}

