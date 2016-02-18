namespace DotNetAnalytics.Google.Dimensions
{
	public class BrowserSizeDimension: Dimension<string>
	{
		/// <summary>
		/// 	The browser size used by users to your website. For example, 1024x768.
		/// </summary>
		public BrowserSizeDimension(): base("Browser Size","The browser size used by users to your website. For example, 1024x768.",true,"ga:browserSize")
		{
			
		}
	}
}

