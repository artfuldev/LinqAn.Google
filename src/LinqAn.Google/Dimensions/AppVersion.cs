using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The version of the application.
	/// </summary>
	[Description("The version of the application.")]
	public class AppVersion: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AppVersion" />.
		/// </summary>
		public AppVersion(): base("App Version",true,"ga:appVersion")
		{
			
		}
	}
}

