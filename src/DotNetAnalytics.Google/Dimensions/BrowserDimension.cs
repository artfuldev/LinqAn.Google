namespace DotNetAnalytics.Google.Dimensions
{
	public class BrowserDimension: Dimension<string>
	{
		/// <summary>
		/// 	The names of browsers used by users to your website. For example, Internet Explorer or Firefox.
		/// </summary>
		public BrowserDimension(): base("Browser","The names of browsers used by users to your website. For example, Internet Explorer or Firefox.",true,"ga:browser")
		{
			
		}
	}
}

