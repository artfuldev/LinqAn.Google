namespace DotNetAnalytics.Google.Dimensions
{
	public class MobileDeviceModelDimension: Dimension<string>
	{
		/// <summary>
		/// 	Mobile device model.
		/// </summary>
		public MobileDeviceModelDimension(): base("Mobile Device Model","Mobile device model.",true,"ga:mobileDeviceModel")
		{
			
		}
	}
}

