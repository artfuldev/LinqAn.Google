namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id
    ///     is set based on the PackageManager#getInstallerPackageName method.
    /// </summary>
    public class AppInstallerID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AppInstallerID" />.
        /// </summary>
        public AppInstallerID()
            : base(
                "App Installer ID",
                "ID of the installer (e.g., Google Play Store) from which the app was downloaded. By default, the app installer id is set based on the PackageManager#getInstallerPackageName method.",
                true, "ga:appInstallerId")
        {
        }
    }
}