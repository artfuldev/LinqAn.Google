using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The marketing name used for the mobile device.
	/// </summary>
	[Description("The marketing name used for the mobile device.")]
	public class MobileDeviceMarketingName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="MobileDeviceMarketingName" />.
		/// </summary>
		public MobileDeviceMarketingName(): base("Mobile Device Marketing Name",true,"ga:mobileDeviceMarketingName")
		{
			
		}
	}
}

