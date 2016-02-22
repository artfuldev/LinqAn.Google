using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The screen resolution of users' screens. For example: 1024x738.
	/// </summary>
	[Description("The screen resolution of users' screens. For example: 1024x738.")]
	public class ScreenResolution: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ScreenResolution" />.
		/// </summary>
		public ScreenResolution(): base("Screen Resolution",true,"ga:screenResolution")
		{
			
		}
	}
}

