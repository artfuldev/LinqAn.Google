namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	This dimension rolls up all the page paths in the first hierarchical level in pagePath.
	/// </summary>
	public class PagePathLevel1Dimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="PagePathLevel1Dimension" />.
		/// </summary>
		public PagePathLevel1Dimension(): base("Page path level 1","This dimension rolls up all the page paths in the first hierarchical level in pagePath.",false,"ga:pagePathLevel1")
		{
			
		}
	}
}

