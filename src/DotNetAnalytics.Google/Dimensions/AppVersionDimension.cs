namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The version of the application.
	/// </summary>
	public class AppVersionDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AppVersionDimension" />.
		/// </summary>
		public AppVersionDimension(): base("App Version","The version of the application.",true,"ga:appVersion")
		{
			
		}
	}
}

