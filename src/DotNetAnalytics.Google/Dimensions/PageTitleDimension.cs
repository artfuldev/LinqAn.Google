namespace DotNetAnalytics.Google.Dimensions
{
	public class PageTitleDimension: Dimension<string>
	{
		/// <summary>
		/// 	The title of a page. Keep in mind that multiple pages might have the same page title.
		/// </summary>
		public PageTitleDimension(): base("Page Title","The title of a page. Keep in mind that multiple pages might have the same page title.",true,"ga:pageTitle")
		{
			
		}
	}
}

