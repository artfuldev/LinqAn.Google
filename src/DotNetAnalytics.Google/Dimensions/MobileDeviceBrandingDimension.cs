namespace DotNetAnalytics.Google.Dimensions
{
	public class MobileDeviceBrandingDimension: Dimension<string>
	{
		/// <summary>
		/// 	Mobile manufacturer or branded name.
		/// </summary>
		public MobileDeviceBrandingDimension(): base("Mobile Device Branding","Mobile manufacturer or branded name.",true,"ga:mobileDeviceBranding")
		{
			
		}
	}
}

