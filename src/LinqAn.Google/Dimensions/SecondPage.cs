namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The second page in a user's session.
    /// </summary>
    public class SecondPage : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="SecondPage" />.
        /// </summary>
        public SecondPage() : base("Second Page", "The second page in a user's session.", false, "ga:secondPagePath")
        {
        }
    }
}