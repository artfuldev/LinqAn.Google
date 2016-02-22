using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the screen when the user exited the application.
	/// </summary>
	[Description("The name of the screen when the user exited the application.")]
	public class ExitScreenName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ExitScreenName" />.
		/// </summary>
		public ExitScreenName(): base("Exit Screen",true,"ga:exitScreenName")
		{
			
		}
	}
}

