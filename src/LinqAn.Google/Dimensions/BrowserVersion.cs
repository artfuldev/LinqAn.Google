using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The browser versions used by users to your website. For example, 2.0.0.14
	/// </summary>
	[Description("The browser versions used by users to your website. For example, 2.0.0.14")]
	public class BrowserVersion: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="BrowserVersion" />.
		/// </summary>
		public BrowserVersion(): base("Browser Version",true,"ga:browserVersion")
		{
			
		}
	}
}

