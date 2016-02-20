namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total number of sessions that included an internal search
    /// </summary>
    public class SessionsWithSearch : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SessionsWithSearch" />.
        /// </summary>
        public SessionsWithSearch()
            : base(
                "Sessions with Search", "The total number of sessions that included an internal search", true,
                "ga:searchSessions")
        {
        }
    }
}