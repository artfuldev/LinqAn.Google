using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Mobile device model.
	/// </summary>
	[Description("Mobile device model.")]
	public class MobileDeviceModel: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="MobileDeviceModel" />.
		/// </summary>
		public MobileDeviceModel(): base("Mobile Device Model",true,"ga:mobileDeviceModel")
		{
			
		}
	}
}

