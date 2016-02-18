namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id
    ///     is set based on the PackageManager#getInstallerPackageName method.
    /// </summary>
    public class AppInstallerIDDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AppInstallerIDDimension" />.
        /// </summary>
        public AppInstallerIDDimension()
            : base(
                "App Installer ID",
                "ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id is set based on the PackageManager#getInstallerPackageName method.",
                true, "ga:appInstallerId")
        {
        }
    }
}