namespace DotNetAnalytics.Google.Dimensions
{
	public class AppNameDimension: Dimension<string>
	{
		/// <summary>
		/// 	The name of the application.
		/// </summary>
		public AppNameDimension(): base("App Name","The name of the application.",true,"ga:appName")
		{
			
		}
	}
}

