using Google.Apis.Services;

namespace LinqAn.Google.Profiles
{
    /// <summary>
    ///     Encapsulates profile information used to connect to the Google Analytics API.
    /// </summary>
    public interface IAnalyticsProfile
    {
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

        /// <summary>
        ///     Creates a <seealso cref="BaseClientService.Initializer" /> instance corresponding to this
        ///     <seealso cref="IAnalyticsProfile" />.
        /// </summary>
        /// <returns>
        ///     A <seealso cref="BaseClientService.Initializer" /> instance corresponding to this
        ///     <seealso cref="IAnalyticsProfile" />.
        /// </returns>
        BaseClientService.Initializer ToBaseClientServiceInitializer();
    }
}