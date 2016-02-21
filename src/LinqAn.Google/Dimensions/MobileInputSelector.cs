namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus).
	/// </summary>
	public class MobileInputSelector: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="MobileInputSelector" />.
		/// </summary>
		public MobileInputSelector(): base("Mobile Input Selector","Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus).",true,"ga:mobileInputSelector")
		{
			
		}
	}
}

