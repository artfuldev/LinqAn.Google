using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The branding, model, and marketing name used to identify the mobile device.
	/// </summary>
	[Description("The branding, model, and marketing name used to identify the mobile device.")]
	public class MobileDeviceInfo: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="MobileDeviceInfo" />.
		/// </summary>
		public MobileDeviceInfo(): base("Mobile Device Info",true,"ga:mobileDeviceInfo")
		{
			
		}
	}
}

