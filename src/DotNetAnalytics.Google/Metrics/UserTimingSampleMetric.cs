namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.
    /// </summary>
    public class UserTimingSampleMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="UserTimingSampleMetric" />.
        /// </summary>
        public UserTimingSampleMetric()
            : base(
                "User Timing Sample",
                "The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.",
                false, "ga:userTimingSample")
        {
        }
    }
}