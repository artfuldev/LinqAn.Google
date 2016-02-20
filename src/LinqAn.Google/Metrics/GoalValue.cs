namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total numeric value for all goals defined for your profile.
    /// </summary>
    public class GoalValue : Metric<decimal>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="GoalValue" />.
        /// </summary>
        public GoalValue()
            : base(
                "Goal Value", "The total numeric value for all goals defined for your profile.", true, "ga:goalValueAll"
                )
        {
        }
    }
}