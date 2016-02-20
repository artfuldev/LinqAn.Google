namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total number of starts for all goals defined for your profile.
    /// </summary>
    public class GoalStarts : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="GoalStarts" />.
        /// </summary>
        public GoalStarts()
            : base(
                "Goal Starts", "The total number of starts for all goals defined for your profile.", true,
                "ga:goalStartsAll")
        {
        }
    }
}