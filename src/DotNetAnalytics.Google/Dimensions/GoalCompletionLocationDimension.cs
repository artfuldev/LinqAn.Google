namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The page path or screen name that matched any destination type goal completion.
    /// </summary>
    public class GoalCompletionLocationDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="GoalCompletionLocationDimension" />.
        /// </summary>
        public GoalCompletionLocationDimension()
            : base(
                "Goal Completion Location",
                "The page path or screen name that matched any destination type goal completion.", false,
                "ga:goalCompletionLocation")
        {
        }
    }
}