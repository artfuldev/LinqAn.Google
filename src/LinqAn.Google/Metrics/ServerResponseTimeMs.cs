namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total amount of time (in milliseconds) your server takes to respond to a user request among all samples,
    ///     including the network time from user's location to your server.
    /// </summary>
    public class ServerResponseTimeMs : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ServerResponseTimeMs" />.
        /// </summary>
        public ServerResponseTimeMs()
            : base(
                "Server Response Time (ms)",
                "The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from user's location to your server.",
                false, "ga:serverResponseTime")
        {
        }
    }
}