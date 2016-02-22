using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page.
	/// </summary>
	[Description("A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page.")]
	public class PagePath: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PagePath" />.
		/// </summary>
		public PagePath(): base("Page",true,"ga:pagePath")
		{
			
		}
	}
}

