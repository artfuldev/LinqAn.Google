using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Mobile manufacturer or branded name.
	/// </summary>
	[Description("Mobile manufacturer or branded name.")]
	public class MobileDeviceBranding: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="MobileDeviceBranding" />.
		/// </summary>
		public MobileDeviceBranding(): base("Mobile Device Branding",true,"ga:mobileDeviceBranding")
		{
			
		}
	}
}

