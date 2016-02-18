namespace DotNetAnalytics.Google.Dimensions
{
	public class MobileDeviceMarketingNameDimension: Dimension<string>
	{
		/// <summary>
		/// 	The marketing name used for the mobile device.
		/// </summary>
		public MobileDeviceMarketingNameDimension(): base("Mobile Device Marketing Name","The marketing name used for the mobile device.",true,"ga:mobileDeviceMarketingName")
		{
			
		}
	}
}

