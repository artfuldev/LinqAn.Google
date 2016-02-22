namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The version of the application.
	/// </summary>
	public class AppVersion: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AppVersion" />.
		/// </summary>
		public AppVersion(): base("App Version","The version of the application.",true,"ga:appVersion")
		{
			
		}
	}
}

