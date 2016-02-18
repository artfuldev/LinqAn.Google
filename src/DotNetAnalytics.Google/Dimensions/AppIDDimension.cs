namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The ID of the application.
	/// </summary>
	public class AppIDDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AppIDDimension" />.
		/// </summary>
		public AppIDDimension(): base("App ID","The ID of the application.",true,"ga:appId")
		{
			
		}
	}
}

