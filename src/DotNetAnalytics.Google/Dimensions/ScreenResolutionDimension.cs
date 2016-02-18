namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The screen resolution of users' screens. For example: 1024x738.
	/// </summary>
	public class ScreenResolutionDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ScreenResolutionDimension" />.
		/// </summary>
		public ScreenResolutionDimension(): base("Screen Resolution","The screen resolution of users' screens. For example: 1024x738.",true,"ga:screenResolution")
		{
			
		}
	}
}

