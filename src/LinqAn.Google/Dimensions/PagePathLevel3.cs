using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	This dimension rolls up all the page paths in the third hierarchical level in pagePath.
	/// </summary>
	[Description("This dimension rolls up all the page paths in the third hierarchical level in pagePath.")]
	public class PagePathLevel3: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PagePathLevel3" />.
		/// </summary>
		public PagePathLevel3(): base("Page path level 3",false,"ga:pagePathLevel3")
		{
			
		}
	}
}

