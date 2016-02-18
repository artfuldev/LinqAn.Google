namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The last page in a user's session, or exit page.
    /// </summary>
    public class ExitPageDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ExitPageDimension" />.
        /// </summary>
        public ExitPageDimension()
            : base("Exit Page", "The last page in a user's session, or exit page.", true, "ga:exitPagePath")
        {
        }
    }
}