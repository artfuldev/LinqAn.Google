using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	This dimension rolls up all the page paths in the second hierarchical level in pagePath.
	/// </summary>
	[Description("This dimension rolls up all the page paths in the second hierarchical level in pagePath.")]
	public class PagePathLevel2: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PagePathLevel2" />.
		/// </summary>
		public PagePathLevel2(): base("Page path level 2",false,"ga:pagePathLevel2")
		{
			
		}
	}
}

