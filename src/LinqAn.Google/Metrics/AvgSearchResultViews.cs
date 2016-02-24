using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average number of times people viewed a search results page after performing a search.
	/// </summary>
	[Description("The average number of times people viewed a search results page after performing a search.")]
	public class AvgSearchResultViews: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgSearchResultViews" />.
		/// </summary>
		public AvgSearchResultViews(): base("Results Pageviews / Search",false,"ga:avgSearchResultViews")
		{
			
		}
	}
}

