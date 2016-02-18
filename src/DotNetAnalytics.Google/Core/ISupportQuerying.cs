namespace DotNetAnalytics.Google.Core
{
    /// <summary>
    ///     Represents an entity that supports querying against Google Analytics.
    /// </summary>
    public interface ISupportQuerying
    {
        /// <summary>
        ///     The name of this <seealso cref="ISupportQuerying" /> when passed to a Google Analytics API query.
        /// </summary>
        string QueryName { get; }
    }
}