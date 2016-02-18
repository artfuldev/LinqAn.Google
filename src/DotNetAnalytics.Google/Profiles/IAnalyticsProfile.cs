namespace DotNetAnalytics.Google.Profiles
{
    /// <summary>
    ///     Encapsulates profile information used to connect to the Google Analytics API.
    /// </summary>
    public interface IAnalyticsProfile
    {
        /// <summary>
        ///     The numeric id number of the View to connect to.
        /// </summary>
        uint ViewId { get; }

        /// <summary>
        ///     The email address of the service account connected to the View.
        /// </summary>
        string ServiceAccountEmail { get; }

        /// <summary>
        ///     The path to the credential key file as a .p12 file.
        /// </summary>
        string KeyFilePath { get; }

        /// <summary>
        ///     The name of the application requesting analytics, for reporting purposes.
        /// </summary>
        string ApplicationName { get; }
    }
}