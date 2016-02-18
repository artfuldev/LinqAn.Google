namespace DotNetAnalytics.Google.Dimensions
{
	public class MobileInputSelectorDimension: Dimension<string>
	{
		/// <summary>
		/// 	Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus).
		/// </summary>
		public MobileInputSelectorDimension(): base("Mobile Input Selector","Selector used on the mobile device (e.g.: touchscreen, joystick, clickwheel, stylus).",true,"ga:mobileInputSelector")
		{
			
		}
	}
}

