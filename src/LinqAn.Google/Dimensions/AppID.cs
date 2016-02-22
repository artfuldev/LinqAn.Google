using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The ID of the application.
	/// </summary>
	[Description("The ID of the application.")]
	public class AppId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AppId" />.
		/// </summary>
		public AppId(): base("App ID",true,"ga:appId")
		{
			
		}
	}
}

