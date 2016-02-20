namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.
    /// </summary>
    public class ServerConnectionTimeMs : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ServerConnectionTimeMs" />.
        /// </summary>
        public ServerConnectionTimeMs()
            : base(
                "Server Connection Time (ms)",
                "The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.",
                false, "ga:serverConnectionTime")
        {
        }
    }
}