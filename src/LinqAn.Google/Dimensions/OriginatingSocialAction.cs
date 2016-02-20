namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     For a social data hub activity, this value represents the type of social action associated with the activity (e.g.
    ///     vote, comment, +1, etc.).
    /// </summary>
    public class OriginatingSocialAction : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="OriginatingSocialAction" />.
        /// </summary>
        public OriginatingSocialAction()
            : base(
                "Originating Social Action",
                "For a social data hub activity, this value represents the type of social action associated with the activity (e.g. vote, comment, +1, etc.).",
                false, "ga:socialActivityAction")
        {
        }
    }
}