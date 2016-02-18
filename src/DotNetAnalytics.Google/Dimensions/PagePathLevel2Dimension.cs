namespace DotNetAnalytics.Google.Dimensions
{
	public class PagePathLevel2Dimension: Dimension<string>
	{
		/// <summary>
		/// 	This dimension rolls up all the page paths in the second hierarchical level in pagePath.
		/// </summary>
		public PagePathLevel2Dimension(): base("Page path level 2","This dimension rolls up all the page paths in the second hierarchical level in pagePath.",false,"ga:pagePathLevel2")
		{
			
		}
	}
}

