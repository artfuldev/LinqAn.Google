namespace DotNetAnalytics.Google.Dimensions
{
	public class AppInstallerIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id is set based on the PackageManager#getInstallerPackageName method.
		/// </summary>
		public AppInstallerIDDimension(): base("App Installer ID","ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id is set based on the PackageManager#getInstallerPackageName method.",true,"ga:appInstallerId")
		{
			
		}
	}
}

