namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The page path or screen name that matched any destination type goal, one step prior to the goal completion
    ///     location.
    /// </summary>
    public class GoalPreviousStep1 : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="GoalPreviousStep1" />.
        /// </summary>
        public GoalPreviousStep1()
            : base(
                "Goal Previous Step - 1",
                "The page path or screen name that matched any destination type goal, one step prior to the goal completion location.",
                false, "ga:goalPreviousStep1")
        {
        }
    }
}