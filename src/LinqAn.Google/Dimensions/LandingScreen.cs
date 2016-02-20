namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The name of the first screen viewed.
    /// </summary>
    public class LandingScreen : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LandingScreen" />.
        /// </summary>
        public LandingScreen()
            : base("Landing Screen", "The name of the first screen viewed.", true, "ga:landingScreenName")
        {
        }
    }
}