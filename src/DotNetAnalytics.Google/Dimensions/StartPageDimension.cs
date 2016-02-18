namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     A page where the user initiated an internal search.
    /// </summary>
    public class StartPageDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="StartPageDimension" />.
        /// </summary>
        public StartPageDimension()
            : base("Start Page", "A page where the user initiated an internal search.", false, "ga:searchStartPage")
        {
        }
    }
}