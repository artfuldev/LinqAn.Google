namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The branding, model, and marketing name used to identify the mobile device.
	/// </summary>
	public class MobileDeviceInfo: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="MobileDeviceInfo" />.
		/// </summary>
		public MobileDeviceInfo(): base("Mobile Device Info","The branding, model, and marketing name used to identify the mobile device.",true,"ga:mobileDeviceInfo")
		{
			
		}
	}
}

