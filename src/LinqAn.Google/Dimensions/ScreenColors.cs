using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The color depth of users' monitors, as retrieved from the DOM of the user's browser. For example 4-bit, 8-bit, 24-bit, or undefined-bit.
	/// </summary>
	[Description("The color depth of users' monitors, as retrieved from the DOM of the user's browser. For example 4-bit, 8-bit, 24-bit, or undefined-bit.")]
	public class ScreenColors: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ScreenColors" />.
		/// </summary>
		public ScreenColors(): base("Screen Colors",true,"ga:screenColors")
		{
			
		}
	}
}

