using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
	/// </summary>
	[Description("The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.")]
	public class ContentGroupUniqueViews5: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ContentGroupUniqueViews5" />.
		/// </summary>
		public ContentGroupUniqueViews5(): base("Unique Views 5",false,"ga:contentGroupUniqueViews5")
		{
			
		}
	}
}

