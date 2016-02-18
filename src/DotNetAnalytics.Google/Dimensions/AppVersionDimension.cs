namespace DotNetAnalytics.Google.Dimensions
{
	public class AppVersionDimension: Dimension<string>
	{
		/// <summary>
		/// 	The version of the application.
		/// </summary>
		public AppVersionDimension(): base("App Version","The version of the application.",true,"ga:appVersion")
		{
			
		}
	}
}

