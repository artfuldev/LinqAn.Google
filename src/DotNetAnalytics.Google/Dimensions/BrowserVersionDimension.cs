namespace DotNetAnalytics.Google.Dimensions
{
	public class BrowserVersionDimension: Dimension<string>
	{
		/// <summary>
		/// 	The browser versions used by users to your website. For example, 2.0.0.14
		/// </summary>
		public BrowserVersionDimension(): base("Browser Version","The browser versions used by users to your website. For example, 2.0.0.14",true,"ga:browserVersion")
		{
			
		}
	}
}

