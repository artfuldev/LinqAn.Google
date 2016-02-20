namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The page path or screen name that matched any destination type goal, two steps prior to the goal completion
    ///     location.
    /// </summary>
    public class GoalPreviousStep2 : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="GoalPreviousStep2" />.
        /// </summary>
        public GoalPreviousStep2()
            : base(
                "Goal Previous Step - 2",
                "The page path or screen name that matched any destination type goal, two steps prior to the goal completion location.",
                false, "ga:goalPreviousStep2")
        {
        }
    }
}