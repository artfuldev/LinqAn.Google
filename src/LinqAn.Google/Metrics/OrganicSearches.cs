using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of organic searches that happened within a session. This metric is search engine agnostic.
	/// </summary>
	[Description("The number of organic searches that happened within a session. This metric is search engine agnostic.")]
	public class OrganicSearches: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="OrganicSearches" />.
		/// </summary>
		public OrganicSearches(): base("Organic Searches",false,"ga:organicSearches")
		{
			
		}
	}
}

