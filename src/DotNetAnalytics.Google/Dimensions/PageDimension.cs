namespace DotNetAnalytics.Google.Dimensions
{
	public class PageDimension: Dimension<string>
	{
		/// <summary>
		/// 	A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page.
		/// </summary>
		public PageDimension(): base("Page","A page on your website specified by path and/or query parameters. Use in conjunction with hostname to get the full URL of the page.",true,"ga:pagePath")
		{
			
		}
	}
}

