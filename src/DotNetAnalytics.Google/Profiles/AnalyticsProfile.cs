namespace DotNetAnalytics.Google.Profiles
{
    /// <summary>
    ///     Encapsulates profile information used to connect to the Google Analytics API.
    /// </summary>
    public class AnalyticsProfile : IAnalyticsProfile
    {
        /// <summary>
        ///     Instantiates an <seealso cref="AnalyticsProfile" /> with the given service account email, key file, and
        ///     application name.
        /// </summary>
        /// <param name="serviceAccountEmail">The email address of the service account connected to the View.</param>
        /// <param name="keyFilePath">The path to the credential key file as a .p12 file.</param>
        /// <param name="applicationName">The name of the application requesting analytics, for reporting purposes.</param>
        public AnalyticsProfile(string serviceAccountEmail, string keyFilePath, string applicationName)
        {
            ServiceAccountEmail = serviceAccountEmail;
            KeyFilePath = keyFilePath;
            ApplicationName = applicationName;
        }

        /// <summary>
        ///     The email address of the service account connected to the View.
        /// </summary>
        public string ServiceAccountEmail { get; }

        /// <summary>
        ///     The path to the credential key file as a .p12 file.
        /// </summary>
        public string KeyFilePath { get; }

        /// <summary>
        ///     The name of the application requesting analytics, for reporting purposes.
        /// </summary>
        public string ApplicationName { get; }
    }
}