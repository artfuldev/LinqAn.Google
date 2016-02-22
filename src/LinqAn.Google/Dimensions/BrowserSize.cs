using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The browser size used by users to your website. For example, 1024x768.
	/// </summary>
	[Description("The browser size used by users to your website. For example, 1024x768.")]
	public class BrowserSize: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="BrowserSize" />.
		/// </summary>
		public BrowserSize(): base("Browser Size",true,"ga:browserSize")
		{
			
		}
	}
}

