using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of unique page views. Page views within different sessions count as separate unique page views. This takes into account both the pagePath and pageTitle to determine uniqueness.
	/// </summary>
	[Description("The number of unique page views. Page views within different sessions count as separate unique page views. This takes into account both the pagePath and pageTitle to determine uniqueness.")]
	public class UniquePageviews: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UniquePageviews" />.
		/// </summary>
		public UniquePageviews(): base("Unique Pageviews",true,"ga:uniquePageviews")
		{
			
		}
	}
}

