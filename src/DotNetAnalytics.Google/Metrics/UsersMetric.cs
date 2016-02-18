namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total number of users for the requested time period.
    /// </summary>
    public class UsersMetric : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="UsersMetric" />.
        /// </summary>
        public UsersMetric()
            : base("Users", "The total number of users for the requested time period.", false, "ga:users")
        {
        }
    }
}