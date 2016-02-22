using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the screen.
	/// </summary>
	[Description("The name of the screen.")]
	public class ScreenName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ScreenName" />.
		/// </summary>
		public ScreenName(): base("Screen Name",true,"ga:screenName")
		{
			
		}
	}
}

