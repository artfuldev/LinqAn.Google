using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of subsequent page views made after a use of your internal search feature.
	/// </summary>
	[Description("The total number of subsequent page views made after a use of your internal search feature.")]
	public class SearchDepth: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchDepth" />.
		/// </summary>
		public SearchDepth(): base("Search Depth",true,"ga:searchDepth")
		{
			
		}
	}
}

