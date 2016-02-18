namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total number of sessions.
    /// </summary>
    public class SessionsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SessionsMetric" />.
        /// </summary>
        public SessionsMetric() : base("Sessions", "The total number of sessions.", true, "ga:sessions")
        {
        }
    }
}