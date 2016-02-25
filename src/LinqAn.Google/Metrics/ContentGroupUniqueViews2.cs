using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
	/// </summary>
	[Description("The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.")]
	public class ContentGroupUniqueViews2: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ContentGroupUniqueViews2" />.
		/// </summary>
		public ContentGroupUniqueViews2(): base("Unique Views 2",false,"ga:contentGroupUniqueViews2")
		{
			
		}
	}
}

