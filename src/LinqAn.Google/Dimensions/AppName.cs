using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the application.
	/// </summary>
	[Description("The name of the application.")]
	public class AppName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AppName" />.
		/// </summary>
		public AppName(): base("App Name",true,"ga:appName")
		{
			
		}
	}
}

