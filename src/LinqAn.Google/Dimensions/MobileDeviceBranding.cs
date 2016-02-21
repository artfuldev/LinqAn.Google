namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Mobile manufacturer or branded name.
	/// </summary>
	public class MobileDeviceBranding: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="MobileDeviceBranding" />.
		/// </summary>
		public MobileDeviceBranding(): base("Mobile Device Branding","Mobile manufacturer or branded name.",true,"ga:mobileDeviceBranding")
		{
			
		}
	}
}

