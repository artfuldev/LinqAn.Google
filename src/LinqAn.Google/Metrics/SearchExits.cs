using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of exits on your site that occurred following a search result from your internal search feature.
	/// </summary>
	[Description("The number of exits on your site that occurred following a search result from your internal search feature.")]
	public class SearchExits: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchExits" />.
		/// </summary>
		public SearchExits(): base("Search Exits",true,"ga:searchExits")
		{
			
		}
	}
}

