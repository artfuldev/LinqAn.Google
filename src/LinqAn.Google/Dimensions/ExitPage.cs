namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The last page in a user's session, or exit page.
    /// </summary>
    public class ExitPage : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ExitPage" />.
        /// </summary>
        public ExitPage()
            : base("Exit Page", "The last page in a user's session, or exit page.", true, "ga:exitPagePath")
        {
        }
    }
}