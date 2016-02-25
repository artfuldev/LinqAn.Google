using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
	/// </summary>
	[Description("The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.")]
	public class ContentGroupUniqueViews1: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ContentGroupUniqueViews1" />.
		/// </summary>
		public ContentGroupUniqueViews1(): base("Unique Views 1",false,"ga:contentGroupUniqueViews1")
		{
			
		}
	}
}

