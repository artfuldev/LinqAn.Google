namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The browser versions used by users to your website. For example, 2.0.0.14
	/// </summary>
	public class BrowserVersionDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="BrowserVersionDimension" />.
		/// </summary>
		public BrowserVersionDimension(): base("Browser Version","The browser versions used by users to your website. For example, 2.0.0.14",true,"ga:browserVersion")
		{
			
		}
	}
}

