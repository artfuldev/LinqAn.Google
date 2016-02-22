using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus).
	/// </summary>
	[Description("Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus).")]
	public class MobileInputSelector: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="MobileInputSelector" />.
		/// </summary>
		public MobileInputSelector(): base("Mobile Input Selector",true,"ga:mobileInputSelector")
		{
			
		}
	}
}

