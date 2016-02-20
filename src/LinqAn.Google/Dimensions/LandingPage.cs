namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The first page in a user's session, or landing page.
    /// </summary>
    public class LandingPage : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LandingPage" />.
        /// </summary>
        public LandingPage()
            : base("Landing Page", "The first page in a user's session, or landing page.", true, "ga:landingPagePath")
        {
        }
    }
}