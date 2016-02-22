namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id is set based on the PackageManager#getInstallerPackageName method.
	/// </summary>
	public class AppInstallerId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AppInstallerId" />.
		/// </summary>
		public AppInstallerId(): base("App Installer ID","ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id is set based on the PackageManager#getInstallerPackageName method.",true,"ga:appInstallerId")
		{
			
		}
	}
}

