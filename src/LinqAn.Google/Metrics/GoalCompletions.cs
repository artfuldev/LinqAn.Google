namespace LinqAn.Google.Metrics
{
    /// <summary>
    ///     The total number of completions for all goals defined for your profile.
    /// </summary>
    public class GoalCompletions : Metric<int>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="GoalCompletions" />.
        /// </summary>
        public GoalCompletions()
            : base(
                "Goal Completions", "The total number of completions for all goals defined for your profile.", true,
                "ga:goalCompletionsAll")
        {
        }
    }
}