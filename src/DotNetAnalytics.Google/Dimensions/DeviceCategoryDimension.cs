namespace DotNetAnalytics.Google.Dimensions
{
	public class DeviceCategoryDimension: Dimension<string>
	{
		/// <summary>
		/// 	The type of device: desktop, tablet, or mobile.
		/// </summary>
		public DeviceCategoryDimension(): base("Device Category","The type of device: desktop, tablet, or mobile.",true,"ga:deviceCategory")
		{
			
		}
	}
}

