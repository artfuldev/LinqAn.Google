namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The names of browsers used by users to your website. For example, Internet Explorer or Firefox.
	/// </summary>
	public class BrowserDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="BrowserDimension" />.
		/// </summary>
		public BrowserDimension(): base("Browser","The names of browsers used by users to your website. For example, Internet Explorer or Firefox.",true,"ga:browser")
		{
			
		}
	}
}

