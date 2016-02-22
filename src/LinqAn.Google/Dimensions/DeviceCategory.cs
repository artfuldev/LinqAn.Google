using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The type of device: desktop, tablet, or mobile.
	/// </summary>
	[Description("The type of device: desktop, tablet, or mobile.")]
	public class DeviceCategory: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DeviceCategory" />.
		/// </summary>
		public DeviceCategory(): base("Device Category",true,"ga:deviceCategory")
		{
			
		}
	}
}

