namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The name of the screen.
    /// </summary>
    public class ScreenNameDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ScreenNameDimension" />.
        /// </summary>
        public ScreenNameDimension() : base("Screen Name", "The name of the screen.", true, "ga:screenName")
        {
        }
    }
}