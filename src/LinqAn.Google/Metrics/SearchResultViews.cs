using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times a search result page was viewed after performing a search.
	/// </summary>
	[Description("The number of times a search result page was viewed after performing a search.")]
	public class SearchResultViews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchResultViews" />.
		/// </summary>
		public SearchResultViews(): base("Results Pageviews",false,"ga:searchResultViews")
		{
			
		}
	}
}

