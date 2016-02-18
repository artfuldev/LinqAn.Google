namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total amount of time (in milliseconds) your server takes to respond to a user request among all samples,
    ///     including the network time from user's location to your server.
    /// </summary>
    public class ServerResponseTimeMsMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ServerResponseTimeMsMetric" />.
        /// </summary>
        public ServerResponseTimeMsMetric()
            : base(
                "Server Response Time (ms)",
                "The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.",
                false, "ga:serverResponseTime")
        {
        }
    }
}