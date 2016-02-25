using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.
	/// </summary>
	[Description("The number of unique content group views. Content group views within different sessions count as separate unique content view. This takes into account both the pagePath and pageTitle to determine uniqueness.")]
	public class ContentGroupUniqueViews3: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ContentGroupUniqueViews3" />.
		/// </summary>
		public ContentGroupUniqueViews3(): base("Unique Views 3",false,"ga:contentGroupUniqueViews3")
		{
			
		}
	}
}

