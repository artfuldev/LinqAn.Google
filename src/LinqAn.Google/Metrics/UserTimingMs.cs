namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total number of milliseconds for a user timing.
    /// </summary>
    public class UserTimingMs : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="UserTimingMs" />.
        /// </summary>
        public UserTimingMs()
            : base(
                "User Timing (ms)", "The total number of milliseconds for a user timing.", false, "ga:userTimingValue")
        {
        }
    }
}