namespace DotNetAnalytics.Google.Dimensions
{
	public class AppIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	The ID of the application.
		/// </summary>
		public AppIDDimension(): base("App ID","The ID of the application.",true,"ga:appId")
		{
			
		}
	}
}

