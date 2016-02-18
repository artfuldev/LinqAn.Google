namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The name of the application.
    /// </summary>
    public class AppNameDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AppNameDimension" />.
        /// </summary>
        public AppNameDimension() : base("App Name", "The name of the application.", true, "ga:appName")
        {
        }
    }
}