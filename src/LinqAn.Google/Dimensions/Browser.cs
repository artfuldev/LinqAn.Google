using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The names of browsers used by users to your website. For example, Internet Explorer or Firefox.
	/// </summary>
	[Description("The names of browsers used by users to your website. For example, Internet Explorer or Firefox.")]
	public class Browser: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Browser" />.
		/// </summary>
		public Browser(): base("Browser",true,"ga:browser")
		{
			
		}
	}
}

