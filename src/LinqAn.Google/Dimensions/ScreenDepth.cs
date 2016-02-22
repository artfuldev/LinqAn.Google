using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The number of screenviews per session reported as a string. Can be useful for historgrams.
	/// </summary>
	[Description("The number of screenviews per session reported as a string. Can be useful for historgrams.")]
	public class ScreenDepth: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ScreenDepth" />.
		/// </summary>
		public ScreenDepth(): base("Screen Depth",true,"ga:screenDepth")
		{
			
		}
	}
}

