namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The name of the first screen viewed.
    /// </summary>
    public class LandingScreenDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="LandingScreenDimension" />.
        /// </summary>
        public LandingScreenDimension()
            : base("Landing Screen", "The name of the first screen viewed.", true, "ga:landingScreenName")
        {
        }
    }
}