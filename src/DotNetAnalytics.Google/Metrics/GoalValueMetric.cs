namespace DotNetAnalytics.Google.Metrics
{
    /// <summary>
    ///     The total numeric value for all goals defined for your profile.
    /// </summary>
    public class GoalValueMetric : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="GoalValueMetric" />.
        /// </summary>
        public GoalValueMetric()
            : base(
                "Goal Value", "The total numeric value for all goals defined for your profile.", true, "ga:goalValueAll"
                )
        {
        }
    }
}