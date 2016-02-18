namespace DotNetAnalytics.Google.Dimensions
{
	public class MobileDeviceInfoDimension: Dimension<string>
	{
		/// <summary>
		/// 	The branding, model, and marketing name used to identify the mobile device.
		/// </summary>
		public MobileDeviceInfoDimension(): base("Mobile Device Info","The branding, model, and marketing name used to identify the mobile device.",true,"ga:mobileDeviceInfo")
		{
			
		}
	}
}

