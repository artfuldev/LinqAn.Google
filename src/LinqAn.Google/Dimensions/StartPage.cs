namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     A page where the user initiated an internal search.
    /// </summary>
    public class StartPage : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="StartPage" />.
        /// </summary>
        public StartPage()
            : base("Start Page", "A page where the user initiated an internal search.", false, "ga:searchStartPage")
        {
        }
    }
}