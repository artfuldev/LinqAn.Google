namespace DotNetAnalytics.Google.Dimensions
{
	public class PagePathLevel1Dimension: Dimension<string>
	{
		/// <summary>
		/// 	This dimension rolls up all the page paths in the first hierarchical level in pagePath.
		/// </summary>
		public PagePathLevel1Dimension(): base("Page path level 1","This dimension rolls up all the page paths in the first hierarchical level in pagePath.",false,"ga:pagePathLevel1")
		{
			
		}
	}
}

