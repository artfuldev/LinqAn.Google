namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The type of device: desktop, tablet, or mobile.
	/// </summary>
	public class DeviceCategory: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="DeviceCategory" />.
		/// </summary>
		public DeviceCategory(): base("Device Category","The type of device: desktop, tablet, or mobile.",true,"ga:deviceCategory")
		{
			
		}
	}
}

