using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	This dimension rolls up all the page paths into hierarchical levels. Up to 4 pagePath levels maybe specified. All additional levels in the pagePath hierarchy are also rolled up in this dimension.
	/// </summary>
	[Description("This dimension rolls up all the page paths into hierarchical levels. Up to 4 pagePath levels maybe specified. All additional levels in the pagePath hierarchy are also rolled up in this dimension.")]
	public class PagePathLevel4: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PagePathLevel4" />.
		/// </summary>
		public PagePathLevel4(): base("Page path level 4",false,"ga:pagePathLevel4")
		{
			
		}
	}
}

