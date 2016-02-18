namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus).
	/// </summary>
	public class MobileInputSelectorDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="MobileInputSelectorDimension" />.
		/// </summary>
		public MobileInputSelectorDimension(): base("Mobile Input Selector","Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus).",true,"ga:mobileInputSelector")
		{
			
		}
	}
}

