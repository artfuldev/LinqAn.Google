using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	This dimension rolls up all the page paths in the first hierarchical level in pagePath.
	/// </summary>
	[Description("This dimension rolls up all the page paths in the first hierarchical level in pagePath.")]
	public class PagePathLevel1: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PagePathLevel1" />.
		/// </summary>
		public PagePathLevel1(): base("Page path level 1",false,"ga:pagePathLevel1")
		{
			
		}
	}
}

