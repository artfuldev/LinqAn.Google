namespace DotNetAnalytics.Google.Dimensions
{
	public class ScreenResolutionDimension: Dimension<string>
	{
		/// <summary>
		/// 	The screen resolution of users' screens. For example: 1024x738.
		/// </summary>
		public ScreenResolutionDimension(): base("Screen Resolution","The screen resolution of users' screens. For example: 1024x738.",true,"ga:screenResolution")
		{
			
		}
	}
}

