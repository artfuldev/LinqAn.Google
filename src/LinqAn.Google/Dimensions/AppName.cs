namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the application.
	/// </summary>
	public class AppName: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AppName" />.
		/// </summary>
		public AppName(): base("App Name","The name of the application.",true,"ga:appName")
		{
			
		}
	}
}

